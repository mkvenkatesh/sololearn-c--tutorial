using System;

class BankAccount {
    public static int NumOfAccounts { get; set; }
    private double balance;

    // readonly keyword allows you to set value for a variable during
    // initialization or constructors only. It can't be changed anywhere else in
    // code. readonly doesn't need to be initialized like const does and can
    // contain expressions for assignment unlike const which can only hold
    // literal value.
    private readonly string name = "Guest " + NumOfAccounts;
    private string ssn; // field    

    // auto-property - no need to define a private field and then a public
    // property. the syntax below automatically does that
    public int Age { get; set; }

    public string Ssn { // property
        get { return ssn; } // accessor
        set { // accessor
            if (value != "")
                ssn = value; 
        } 
    }

    // Constructor
    public BankAccount(string name) {
        Console.WriteLine("Initializing bank balance to 100 for {0}", name);
        // this refers to the class member of the instantiated object
        this.name = name;
        balance = 100;
        NumOfAccounts++;
    }

    // Constructor
    public BankAccount() {
        Console.WriteLine("Initializing bank balance to 100 for {0}", name);
        balance = 0;
        NumOfAccounts++;
    }

    // Destructor
    ~BankAccount() {
        Console.WriteLine("Destructor for bank account class.");
        NumOfAccounts--;
    }    

    public string GetName() {
        return this.name;
    }

    public double GetBalance() {
        return balance;
    }

    public void Deposit(double amount) {
        balance += amount;
    }

    public void Withdraw(double amount) {
        balance -= amount;
    }

}