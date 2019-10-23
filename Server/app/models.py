from werkzeug.security import generate_password_hash, check_password_hash
from datetime import datetime
from app import db


link = db.Table('link',
	db.Column('user_id', db.Integer, db.ForeignKey('user.id')),
	db.Column('squad_id', db.Integer, db.ForeignKey('squad.id'))
)


class User(db.Model):
	id = db.Column(db.Integer, primary_key=True, unique=True)
	login = db.Column(db.String(31), index=True, unique=True)
	name = db.Column(db.String(63), nullable=False)
	password_hash = db.Column(db.String(127), nullable=False)
	status = db.Column(db.SmallInteger, nullable=False)

	posts = db.relationship('Post', backref='author', lazy='dynamic')

	def set_password(self, password):
		self.password_hash = generate_password_hash(password)

	def check_password(self, password):
		return check_password_hash(self.password_hash, password)


class Camp(db.Model):
	id = db.Column(db.Integer, primary_key=True, unique=True)
	name = db.Column(db.String(127), nullable=False)
	description = db.Column(db.Text(1023))

	sessions = db.relationship('Session', backref='place', lazy='dynamic')


class Session(db.Model):
	id = db.Column(db.Integer, primary_key=True, unique=True)
	name = db.Column(db.String(127))
	description = db.Column(db.Text(1023))
	date_start = db.Column(db.Date)
	date_end = db.Column(db.Date)
	broadcast = db.Column(db.String(255))

	squads = db.relationship('Squad', backref='sess', lazy='dynamic')

	camp_id = db.Column(db.Integer, db.ForeignKey('camp.id'))


class Squad(db.Model):
	id = db.Column(db.Integer, primary_key=True, unique=True)
	name = db.Column(db.String(127))
	description = db.Column(db.Text(1023))
	age_min = db.Column(db.SmallInteger)
	age_max = db.Column(db.SmallInteger)

	quests = db.relationship('Quest', backref='group', lazy='dynamic')
	posts = db.relationship('Post', backref='group', lazy='dynamic')
	users = db.relationship('User', secondary=link, backref='squads', lazy='dynamic')

	session_id = db.Column(db.Integer, db.ForeignKey('session.id'))


class Quest(db.Model):
	id = db.Column(db.Integer, primary_key=True, unique=True)
	name = db.Column(db.String(127))
	description = db.Column(db.Text(1023))
	date_start = db.Column(db.DateTime)
	duration = db.Column(db.SmallInteger, nullable=False)

	squad_id = db.Column(db.Integer, db.ForeignKey('squad.id'))


class Post(db.Model):
	id = db.Column(db.Integer, primary_key=True, unique=True)
	description = db.Column(db.String(255))
	timestamp = db.Column(db.DateTime, index=True, default=datetime.utcnow)
	status = db.Column(db.Boolean, nullable=False)

	author_id = db.Column(db.Integer, db.ForeignKey('user.id'))
	photo_id = db.Column(db.Integer, db.ForeignKey('photo.id'))
	squad_id = db.Column(db.Integer, db.ForeignKey('squad.id'))


class Photo(db.Model):
	id = db.Column(db.Integer, primary_key=True, unique=True)
	width = db.Column(db.SmallInteger, nullable=False)
	height = db.Column(db.SmallInteger, nullable=False)
	texture_format = db.Column(db.SmallInteger, nullable=False)
	mipmap_count = db.Column(db.SmallInteger, nullable=False)
	bit_file = db.Column(db.String(127), nullable=False)

	posts = db.relationship('Post', backref='image', lazy='dynamic')
