// программа, которая выдает кол-во цифр в числе

Console.WriteLine("введите число - ");
int num = int.Parse(Console.ReadLine());

	    // num = 456654
	    int temp = num;
	    // temp = 456654
	    int revert = 0;
        int i = 0;

	    while (temp > 0)
	    {
	        //revert= 0*10=0 + 4=4
	        //revert= 4*10=40 + 5=45
	        //revert= 45*10=450 + 6=456
	        //revert= 456*10=4560 + 6=4566
	        //revert= 4566*10=45660 +5=45665
	        //revert= 45665*10=456650 + 6=456654
	        revert = (revert * 10) + (temp % 10);
	
	        //temp = 45665
	        //temp = 456
	        //temp = 45
	        //temp = 4
	        temp /= 10;

            i++;
	    }
	
Console.WriteLine($"число {i} - значное");
