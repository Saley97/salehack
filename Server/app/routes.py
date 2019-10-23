# -*- coding: utf-8 -*-
import json
from flask import request
from app import app, messages


# @app.route('/', methods=['POST'])
@app.route('/test', methods=['POST'])
def test():
	res = None
	result = None
	isGET = False

	if (type(request.get_json()) == str):
		res = json.loads(request.get_json().replace('\'', '\"'))
		# if res['serialisedData'] == '':
		# 	isGET = True
	if (type(request.get_json()) == dict):
		res = request.get_json()
		# if res['serialisedData'] == '':
		# 	isGET = True
		# else:
		res['serialisedData'] = json.loads(res['serialisedData'])


	messages.debugInput(res)


	msg = res['type'] // 10
	isGET = res['type'] % 10
	if msg == 0:	# MsgCamp
		result = messages.Camp(isGET, res['serialisedData'])
	elif msg == 1:	# MsgSession
		result = messages.Session(isGET, res['serialisedData'])
	elif msg == 2:	# MsgSquad
		result = messages.Squad(isGET, res['serialisedData'])
	elif msg == 3:	# MsgQuest
		result = messages.Quest(isGET, res['serialisedData'])
	elif msg == 4:	# MsgPost
		result = messages.Post(isGET, res['serialisedData'])
	elif msg == 5:	# MsgUser
		result = messages.User(isGET, res['serialisedData'])
	elif msg == 6:	# MsgPhoto
		result = messages.Photo(isGET, res['serialisedData'])
		print('\tSuccesful computed!\n')
	elif msg == 7:	# MsgBroadcast
		result = messages.Broadcast(isGET, res['serialisedData'])


	messages.debugOutput(result)


	# res['serialisedData'] = str(res['serialisedData'])
	return result

