// Bring in the Billing namespace
using Billing;
// Set up the order
double subtotal = 49.99; 
// Calculate tax and total
double tax = Calculator.CalculateTax(subtotal);
double total = Calculator.CalculateTotal(subtotal, tax);
// Print the receipt
Console.WriteLine($"Subtotal:{subtotal}");
Console.WriteLine($"tax:{tax}");
Console.WriteLine($"total:{total}");
