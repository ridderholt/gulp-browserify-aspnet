'use strict';
var common = require('./common.js');
function Start(common){
	var self = this;
	self.doStuff = function(){
		common.doStuff();
		console.log('Start doing stuff');
	};
	return self;
}
var start = new Start(common);
start.doStuff();

