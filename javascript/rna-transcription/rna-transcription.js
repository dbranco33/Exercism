var Nucleotide = function(){
};

Nucleotide.prototype.toRna = function(input){
	var dnaStrand = input;
	var rnaStrand = [];

	for (var i = 0; i < dnaStrand.length; i++) {
		if(dnaStrand[i]=="G"){
			rnaStrand.push("C");
		}else if(dnaStrand[i]=="C"){
			rnaStrand.push("G");
		}else if(dnaStrand[i]=="T"){
			rnaStrand.push("A");
		}else if(dnaStrand[i]=="A"){
			rnaStrand.push("U");
		}else{
			throw Error("Invalid input");
		};//ends if statement.
	};//ends for loop. 
	
	return rnaStrand.join("");
};

module.exports = Nucleotide;