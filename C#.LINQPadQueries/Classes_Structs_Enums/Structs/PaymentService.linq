<Query Kind="Program" />

//?
void Main()
{
	
}

class Payment 
{ 
	public Payment(int fromAccount, int toAccount, decimal amount)
	{
		
	}
}

sealed class PaymentService
{
	private static PaymentService service; 
	
	private Queue<Payment> payments;
	
	private PaymentService()
	{
		// This is a private constructor; therefore it can only 
		// be called from inside the PaymentService type.
		payments = new Queue<Payment>();
	}
	
	public static PaymentService Service
	{
		get
		{
			// Create service the first time it’s requested. For 
			// the remainder of the program’s lifetime we’ll be 
			// using this singleton instance.
			if (service == null)
			{
				service = new PaymentService();
			}
			
			return service;
		}
	}
	
	public void SchedulePayment(int fromAccount, int toAccount, decimal amount)
	{
		payments.Enqueue(new Payment(fromAccount, toAccount, amount));
	}
}