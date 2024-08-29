using System;
using System.Linq.Expressions;

class ShoppingCart
{
    static void Main(string[] args)
    {
        Q1 obj = new Q1();
        obj.func();

        Q2 obj2 = new Q2();
        obj2.func2();

        Q3 obj3 = new Q3();
        obj3.func3();

        Q4 obj4 = new Q4();
        obj4.func4();

        Q5 obj5 = new Q5();
        obj5.func5();

        Q6 obj6 = new Q6();
        obj6.func6();

        Q7 obj7 = new Q7();
        obj7.func7();

        Q8 obj8 = new Q8();
        obj8.func8();

        Q9 obj9 = new Q9();
        obj9.func9();

        Q10 obj10 = new Q10();
        obj10.func10();
    }
}
class Q1
{
    public void func()
    {
        double[] itemPrices = new double[5];
        double totalPrice = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter the price of item {i + 1}: ");
            itemPrices[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < itemPrices.Length; i++)
        {
            totalPrice += itemPrices[i];
        }

        if (totalPrice > 3000)
        {
            double discount = totalPrice * 0.10;
            totalPrice -= discount;
            Console.WriteLine("A 10% discount has been applied. Discount amount: Rs." + discount);
        }

        Console.WriteLine("The total price of items in the cart is: Rs." + totalPrice);
    }
}
class Q2
{
    public void func2()
    {
        double temp;
        temp = Convert.ToDouble(Console.ReadLine());

        double farehnite = (temp * 1.8) + 32;
        Console.WriteLine("Temperature is " + farehnite + "F");
    }
}
class Q3
{
    public void func3()
    {
        double bal = 54698, amt_w, amt_d;
        int c = 0;
        while (c != 4)
        {
            Console.WriteLine("Choose the number for action you want to perform.");
            Console.WriteLine("1.Check your Balance \n 2.Withdraw Money \n 3.Deposit Money \n 4.To Exit");
            c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine(bal);
                    break;
                case 2:
                    Console.WriteLine("Enter The Amount to be withdrawn");
                    amt_w = double.Parse(Console.ReadLine());
                    bal = bal - amt_w;
                    Console.WriteLine("Amount Withdrawn Succesfully!! Your Current Account Balance is:" + bal);
                    break;
                case 3:
                    Console.WriteLine("Enter the Amount to be deposited:");
                    amt_d = double.Parse(Console.ReadLine());
                    bal = bal + amt_d;
                    Console.WriteLine("Amount Deposited Succesfully!! Your Current Account Balance is:" + bal);
                    break;
                case 4:
                    Console.WriteLine("You are exited Succesfully");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

    }
}
class Q4
{
    public void func4()
    {
        double[] marks = new double[5];
        double avg_marks = 0, tot_marks = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter the marks of Subject" + (i + 1));
            marks[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            tot_marks += marks[i];
        }
        avg_marks = tot_marks / 5;
        Console.WriteLine("Average Marks are:" + avg_marks);

    }
}
class Q5
{
    public void func5()
    {
        String pass;
        int u = 0, l = 0, d = 0;

        Console.WriteLine("Enter Your Password:");

        pass = Console.ReadLine();

        char[] chars = pass.ToCharArray();

        if (chars.Length < 8)
        {
            Console.WriteLine("Invalid Pass");
        }
        else
        {

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                {
                    u++;
                }
                else if (char.IsLower(chars[i]))
                {
                    l++;
                }
                else if (char.IsDigit(chars[i]))
                {
                    d++;
                }
            }

            if (u == 0 || l == 0 || d == 0)
            {
                Console.WriteLine("Invalid Pass");
            }
            else
            {
                Console.WriteLine("Password Saved Succesfully!");
            }
        }
    }
}
class Q6
{
    public void func6()
    {
        int time, sc = 20;
        double dist, r_dist, t_fare;

        Console.WriteLine("Enter the Time (in hours):");

        time = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Distance(in KMs):");

        dist = Convert.ToDouble(Console.ReadLine());

        if (dist < 2)
        {
            if (time > 2200)
            {
                Console.WriteLine("Your fare is :" + (dist * (20 + sc)));
            }
            else
            {
                Console.WriteLine("Your fare is :" + (dist * 20));
            }
        }
        else
        {
            r_dist = dist - 2;
            t_fare = (2 * 20) + (r_dist * 30);

            if (time > 2200)
            {
                Console.WriteLine("Your Fare is:" + (t_fare + (dist * 20)));
            }
            else
            {
                Console.WriteLine("Your Fare is:" + t_fare);

            }
        }

    }
}
class Q7
{
    public void func7()
    {
        string student;
        int i, p = 0, a = 0;
        bool attendance;

        Console.WriteLine("Enter the name of the student");
        student = Console.ReadLine();

        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("\nEnter attendance for day:" + (i + 1));
            Console.WriteLine("Write Y for present and N for absent");
            string x = Console.ReadLine();
            if (x.Contains("Y") || x.Contains("y"))
            {
                attendance = true;
                p++;
            }
            else if (x.Contains("N") || x.Contains("n"))
            {
                attendance = false;
                a++;
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
        Console.WriteLine("Total days attended are:" + p);
        if (p == 5)
        {
            Console.WriteLine(student + " has perfect attendance!");
        }
        else
        {
            Console.WriteLine(student + " does not has perfect attendance!");
        }
    }
}
class Q8
{
    public void func8()
    {
        double[] exp = new double[12];
        double tot = 0, h_exp, l_exp;

        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine("Enter Your Expenses for month" + (i + 1));
            exp[i] = double.Parse(Console.ReadLine());
            tot += exp[i];
        }
        h_exp = exp[0];
        l_exp = exp[0];

        for (int i = 1; i < 12; i++)
        {
            if (exp[i] > h_exp)
            {
                h_exp = exp[i];
            }
            if (exp[i] < l_exp)
            {
                l_exp = exp[i];
            }
        }
        Console.WriteLine("Highest Expense is" + h_exp);
        Console.WriteLine("Lowest Exxpense is" + l_exp);
        Console.WriteLine("Total Expense is" + tot);
    }
}
class Q9
{
    public void func9()
    {

        int c = 0, i = 1, x = 0, j = 0;
        double bill = 0;
        string cart = "Your Cart Items are:\n";

        while (c != 4)
        {
            Console.WriteLine("Choose according to your need");
            Console.WriteLine("1.Add to Cart\n2.Remove from Cart\n3.Total Bill\n4.Exit");
            c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    while (x != 5)
                    {
                        Console.WriteLine("Choose according to your need");
                        Console.WriteLine("1.Jeans   @Rs. 400\n2.Tshirt  @Rs.350\n3.Tank-Top  @Rs.200\n4.Shirt @Rs.450\n5.Exit");
                        x = int.Parse(Console.ReadLine());
                        switch (x)
                        {
                            case 1:
                                cart = cart + " Jeans\n";
                                bill += 400;
                                break;
                            case 2:
                                cart = cart + " Tshirt\n";
                                bill += 350;
                                break;
                            case 3:
                                cart = cart + " Tank-Top\n";
                                bill += 200;
                                break;
                            case 4:
                                cart = cart + " Shirt\n";
                                bill += 450;
                                break;
                            case 5:
                                break;
                            default:
                                Console.WriteLine("Invalid Choice \n");
                                break;
                        }
                        Console.WriteLine(cart + "\n");
                        j++;
                    }
                    break;
                case 2:
                    if (j == 0)
                    {
                        Console.WriteLine("Oops! Your Cart is Empty!\n");
                        break;
                    }

                    else
                    {
                        Console.WriteLine(cart + "\nChoose the item you want to delete\n");
                        string ItemToDelete = Console.ReadLine();

                        if (cart.Contains(ItemToDelete))
                        {
                            cart = cart.Replace(ItemToDelete, "");
                            Console.WriteLine("Updated Cart:" + cart);
                        }
                        else
                        {
                            Console.WriteLine("Your cart dosen't contains:" + ItemToDelete + "\n");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Total bill is:" + bill + "\n");
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid Choice\n");
                    break;
            }
        }
    }

}
class Q10
{
    public void func10()
    {
        double salary = 0, working_hours, hourly_wage;
        Console.WriteLine("Enter the number of employees to calculate their Salary");
        int emp = int.Parse(Console.ReadLine());
        for (int i = 0; i < emp; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine("Enter the wokring hours of Employee " + (i + 1) + " for the " + (j + 1) + " week");
                working_hours = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the hourly wage of employee " + (i + 1) + " for the " + (j + 1) + " week");
                hourly_wage = double.Parse(Console.ReadLine());

                salary += working_hours * hourly_wage;
            }
            Console.WriteLine("Salary of Employee " + (i + 1) + " is " + salary);
        }
    }
}