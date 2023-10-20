class_name Player
extends RigidBody2D

@export var thing : ScriptResourceThing
@export var another_thing : AnotherScriptResourceThing

# Called when the node enters the scene tree for the first time.
func _ready():
	print(thing.string)
	print(another_thing.number)


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass
