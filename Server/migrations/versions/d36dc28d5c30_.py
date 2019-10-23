"""empty message

Revision ID: d36dc28d5c30
Revises: 
Create Date: 2019-10-23 08:36:56.196474

"""
from alembic import op
import sqlalchemy as sa


# revision identifiers, used by Alembic.
revision = 'd36dc28d5c30'
down_revision = None
branch_labels = None
depends_on = None


def upgrade():
    # ### commands auto generated by Alembic - please adjust! ###
    op.create_table('camp',
    sa.Column('id', sa.Integer(), nullable=False),
    sa.Column('name', sa.String(length=127), nullable=False),
    sa.Column('description', sa.Text(length=1023), nullable=True),
    sa.PrimaryKeyConstraint('id'),
    sa.UniqueConstraint('id')
    )
    op.create_table('photo',
    sa.Column('id', sa.Integer(), nullable=False),
    sa.Column('width', sa.SmallInteger(), nullable=False),
    sa.Column('height', sa.SmallInteger(), nullable=False),
    sa.Column('texture_format', sa.SmallInteger(), nullable=False),
    sa.Column('mipmap_count', sa.SmallInteger(), nullable=False),
    sa.Column('bit_file', sa.String(length=127), nullable=False),
    sa.PrimaryKeyConstraint('id'),
    sa.UniqueConstraint('id')
    )
    op.create_table('user',
    sa.Column('id', sa.Integer(), nullable=False),
    sa.Column('login', sa.String(length=31), nullable=True),
    sa.Column('name', sa.String(length=63), nullable=False),
    sa.Column('password_hash', sa.String(length=127), nullable=False),
    sa.Column('status', sa.SmallInteger(), nullable=False),
    sa.PrimaryKeyConstraint('id'),
    sa.UniqueConstraint('id')
    )
    op.create_index(op.f('ix_user_login'), 'user', ['login'], unique=True)
    op.create_table('session',
    sa.Column('id', sa.Integer(), nullable=False),
    sa.Column('name', sa.String(length=127), nullable=True),
    sa.Column('description', sa.Text(length=1023), nullable=True),
    sa.Column('date_start', sa.Date(), nullable=True),
    sa.Column('date_end', sa.Date(), nullable=True),
    sa.Column('broadcast', sa.String(length=255), nullable=True),
    sa.Column('camp_id', sa.Integer(), nullable=True),
    sa.ForeignKeyConstraint(['camp_id'], ['camp.id'], ),
    sa.PrimaryKeyConstraint('id'),
    sa.UniqueConstraint('id')
    )
    op.create_table('squad',
    sa.Column('id', sa.Integer(), nullable=False),
    sa.Column('name', sa.String(length=127), nullable=True),
    sa.Column('description', sa.Text(length=1023), nullable=True),
    sa.Column('age_min', sa.SmallInteger(), nullable=True),
    sa.Column('age_max', sa.SmallInteger(), nullable=True),
    sa.Column('session_id', sa.Integer(), nullable=True),
    sa.ForeignKeyConstraint(['session_id'], ['session.id'], ),
    sa.PrimaryKeyConstraint('id'),
    sa.UniqueConstraint('id')
    )
    op.create_table('link',
    sa.Column('user_id', sa.Integer(), nullable=True),
    sa.Column('squad_id', sa.Integer(), nullable=True),
    sa.ForeignKeyConstraint(['squad_id'], ['squad.id'], ),
    sa.ForeignKeyConstraint(['user_id'], ['user.id'], )
    )
    op.create_table('post',
    sa.Column('id', sa.Integer(), nullable=False),
    sa.Column('description', sa.String(length=255), nullable=True),
    sa.Column('timestamp', sa.DateTime(), nullable=True),
    sa.Column('status', sa.Boolean(), nullable=False),
    sa.Column('author_id', sa.Integer(), nullable=True),
    sa.Column('photo_id', sa.Integer(), nullable=True),
    sa.Column('squad_id', sa.Integer(), nullable=True),
    sa.ForeignKeyConstraint(['author_id'], ['user.id'], ),
    sa.ForeignKeyConstraint(['photo_id'], ['photo.id'], ),
    sa.ForeignKeyConstraint(['squad_id'], ['squad.id'], ),
    sa.PrimaryKeyConstraint('id'),
    sa.UniqueConstraint('id')
    )
    op.create_index(op.f('ix_post_timestamp'), 'post', ['timestamp'], unique=False)
    op.create_table('quest',
    sa.Column('id', sa.Integer(), nullable=False),
    sa.Column('name', sa.String(length=127), nullable=True),
    sa.Column('description', sa.Text(length=1023), nullable=True),
    sa.Column('date_start', sa.DateTime(), nullable=True),
    sa.Column('duration', sa.SmallInteger(), nullable=False),
    sa.Column('squad_id', sa.Integer(), nullable=True),
    sa.ForeignKeyConstraint(['squad_id'], ['squad.id'], ),
    sa.PrimaryKeyConstraint('id'),
    sa.UniqueConstraint('id')
    )
    # ### end Alembic commands ###


def downgrade():
    # ### commands auto generated by Alembic - please adjust! ###
    op.drop_table('quest')
    op.drop_index(op.f('ix_post_timestamp'), table_name='post')
    op.drop_table('post')
    op.drop_table('link')
    op.drop_table('squad')
    op.drop_table('session')
    op.drop_index(op.f('ix_user_login'), table_name='user')
    op.drop_table('user')
    op.drop_table('photo')
    op.drop_table('camp')
    # ### end Alembic commands ###