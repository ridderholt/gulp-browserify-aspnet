'use strict';

function Common(){
	var self = this;

	self.doStuff = function(){
		console.log('Common doing stuff');
	};

	return self;
}

module.exports = new Common();
