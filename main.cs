using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Super init ba? Mag-on ka na lang ng ac!");

    int fanSpeed;
    string oscOption;

    while (true) {
      Console.Write("Enter Fan Speed (1. 2. or 3): " );
      fanSpeed = int.Parse(Console.ReadLine());

      if (fanSpeed >= 1 && fanSpeed <= 3) 
        break;
      Console.WriteLine("Please enter a valid fan speed. ");
    }
 
    Console.WriteLine();

    while (true) {
      Console.Write("Oscilliate your fan? (Y/N): " );
      oscOption = Console.ReadLine().ToUpper();

      if (oscOption == "Y" || oscOption == "N") 
        break;
      Console.WriteLine("Please enter a valid oscilliation. ");
    }

    int baseFanPower = 10;
    int fanPowerOutput = baseFanPower * fanSpeed;

    if (oscOption == "Y") {
      for (int i = 1; i <= 10; i++) {
        Console.WriteLine(new String('~', i * fanSpeed));
      }
      for (int i = baseFanPower; i > 0; i--) {
        Console.WriteLine(new String ('~', i * fanSpeed));
      }
    }
    else {
      for (int i = 0; i <= baseFanPower; i++) {
        Console.WriteLine(new String('~', fanPowerOutput));
      }
    }
    }
  }

    
  

      
    
    