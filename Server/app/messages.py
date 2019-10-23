from app import app, db, models



def debugInput(res=dict()):
	print('||')
	try:
		with open("../output.txt", 'w') as f:
			f.write(str(res))
	except Exception:
		print("\tError writing to file!\n")
	else:
		print("\tWritten!\n")

	print('\tReceived ({}) :\n\t{}\n\t\t{}\n'.format(res.__class__, list(res.keys()), list(res['serialisedData'].keys())))
	return None


def debugOutput(res=dict()):
	print('\tSended ({}) :\n\t{}'.format(res.__class__, res))
	print('||')


# 0 'name', 'description', 'sessions', 'id'
def Camp(isGET=False, data=dict()):
	if isGET:
		cm = models.Camp.query.get(data['id'])
		result = {
			"type": 0,
			"serialisedData": {
				"name": cm.name, 
				"description": cm.description, 
				"sessions": list(ss.id for ss in cm.sessions), 
				"id": cm.id
			}
		}
		result['serialisedData'] = str(result['serialisedData'])
		return result
	else:
		pass


# 1 'name', 'description', 'startDate', 'endDate', 'broadcast', 'squads', 'id'
def Session(isGET=False, data=dict()):
	if isGET:
		ss = models.Session.query.get(data['id'])
		result = {
			"type": 1,
			"serialisedData": {
				"name": ss.name, 
				"description": ss.description, 
				"startDate": ss.date_start, 
				"endDate": ss.date_end, 
				"broadcast": ss.broadcast, 
				"squads": list(sq.id for sq in ss.squads), 
				"id": ss.id
			}
		}
		result['serialisedData'] = str(result['serialisedData'])
		return result
	else:
		pass


# 2 'name', 'minAge', 'maxAge', 'kids', 'staff', 'quests', 'posts', 'id'
def Squad(isGET=False, data=dict()):
	if isGET:
		sq = models.Squad.query.get(data['id'])
		result = {
			"type": 1,
			"serialisedData": {
				"name": sq.name, 
				"minAge": sq.age_min, 
				"maxAge": sq.age_max, 
				"kids": list(us.id for us in sq.users if us.status ==3), 
				"staff": list(us.id for us in sq.users if us.status ==1), 
				"quests": list(qt.id for qt in sq.quests), 
				"posts": list(pt.id for pt in sq.posts), 
				"id": sq.id
			}
		}
		result['serialisedData'] = str(result['serialisedData'])
		return result
	else:
		pass


# 3 'name', 'task', 'startDate', 'duration', 'id'
def Quest(isGET=False, data=dict()):
	if isGET:
		qt = models.Quest.query.get(data['id'])
		result = {
			"type": 3,
			"serialisedData": {
				"name": qt.name, 
				"task": qt.description, 
				"startDate": qt.date_start, 
				"duration": qt.duration, 
				"id": qt.id
			}
		}
		result['serialisedData'] = str(result['serialisedData'])
		return result
	else:
		pass


# 4 'photo', 'text', 'author', 'date', 'status', 'id'
def Post(isGET=False, data=dict()):
	if isGET:
		pt = models.Post.query.get(data['id'])
		result = {
			"type": 1,
			"serialisedData": {
				"photo": pt.photo_id, 
				"text": pt.description, 
				"author": pt.author_id, 
				"date": pt.timestamp, 
				"status": pt.status, 
				"id": pt.id
			}
		}
		result['serialisedData'] = str(result['serialisedData'])
		return result
	else:
		pt = models.Post(description=data['text'],
			status=data['status'],
			author_id=data['author'],
			photo_id=data['photo'],
			squad_id=None)
		db.session.add(pt)
		db.session.commit()

		return str(pt.id)


# 5 'login', 'name', 'passwd', 'uStatus', 'id'
def User(isGET=False, data=dict()):
	if isGET:
		us = models.User.query.get(data['id'])
		result = {
			"type": 5,
			"serialisedData": {
				"login": us.login, 
				"name": us.name, 
				"passwd": us.password_hash, 
				"uStatus": us.status, 
				"id": us.id
			}
		}
		result['serialisedData'] = str(result['serialisedData'])
		return result
	else:
		us = models.User(login=data['login'],
			name=data['name'],
			status=data['uStatus'])
		us.set_password(data['passwd'])
		db.session.add(us)
		db.session.commit()

		return str(us.id)


# 6 'width', 'height', 'format', 'mipmapCount', 'data', 'id'
def Photo(isGET=False, data=dict()):
	if isGET:
		ph = models.Photo.query.get(data['id'])
		with open(ph.bit_file, 'r') as f:
			content = f.read()
		result = {
			"type": 6,
			"serialisedData": {
				"width": ph.width, 
				"height": ph.height, 
				"format": ph.texture_format, 
				"mipmapCount": ph.mipmap_count, 
				"data": content, 
				"id": ph.id
			}
		}
		result['serialisedData'] = str(result['serialisedData'])
		return result
	else:
		ph = models.Photo(width=data['width'], 
			height=data['height'], 
			texture_format=data['format'], 
			mipmap_count=data['mipmapCount'], 
			bit_file=None)
		db.session.add(ph)
		db.session.commit()

		ph.bit_file = "../db/" + "ph" + str(ph.id)
		with open(ph.bit_file, 'w') as f:
			f.write(data['data'])
		db.session.commit()

		return str(ph.id)


# 7 'url', 'id'
def Broadcast(isGET=False, data=dict()):
	return None
