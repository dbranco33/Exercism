//
// This is only a SKELETON file for the "Leap" exercise. It's been provided as a
// convenience to get you started writing code faster.
//

var Year = function (input) {
	this.input = input;
};

Year.prototype.isLeap = function () {
	var yearInput = this.input;
	var flag = false;

	//Tests if the year input is a Leap year.
	if((yearInput%4==0 && yearInput%100!=0) || 
	   (yearInput%4==0 && yearInput%100==0 && yearInput%400==0)){
		flag = true;
	};

	return flag;
};

module.exports = Year;