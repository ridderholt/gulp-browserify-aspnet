'use strict';
var common = require('./common');

function About(common){
	var self = this;

	self.doStuff = function(){
		common.doStuff();
		console.log('About doing stuff');
	};

	return self;
}

var about = new About(common);

about.doStuff();
