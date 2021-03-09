public int RomanToInt(string s) {
        
        //I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000
        
        int arraySize = s.Length;
        
        int[] romanNumerals = new int[arraySize];
        
        int index = 0;
        foreach(char numeral in s){
            if(numeral == 'I'){
                romanNumerals[index] = 1;
            }
            else if(numeral == 'V'){
                romanNumerals[index] = 5;
            }
            else if(numeral == 'X'){
                romanNumerals[index] = 10;
            }
            else if(numeral == 'L'){
                romanNumerals[index] = 50;
            }
            else if(numeral == 'C'){
                romanNumerals[index] = 100;
            }
            else if(numeral == 'D'){
                romanNumerals[index] = 500;
            }
            else if(numeral == 'M'){
                romanNumerals[index] = 1000;
            }
            index++;
        }
        
        //Loop through array
        //If preceding number is less than the current number, subtract that number + add
        //the current number - the preceding
        
        index = 0;
        int modernInteger = 0;
        foreach(int n in romanNumerals){
            
            modernInteger += n;
            
            if(index != 0){
                if(n > romanNumerals[index - 1]){
                    modernInteger = modernInteger - romanNumerals[index - 1] - romanNumerals[index - 1];
                }
            }
            index++;
        }
        
        return modernInteger;
        
}