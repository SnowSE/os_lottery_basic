namespace lottery_basic
{
    public class LotteryVendor
    {
         public  void purchaseTickets(LotteryPeriod period, int sellLimit){
            if (sellLimit<1) {   throw new System.ArgumentException("Parameter cannot be <1", "sellLimit");   }
            for (int i=0;i<sellLimit;i++){
                //need to buy/sell at least one more ticket
                LotteryTicket t1 = new LotteryTicket();
                lock(period.soldTickets){
                    period.soldTickets.Push(t1);
                }
            }
            System.Console.WriteLine("Done selling {0} tickets.",sellLimit);
        }
    }
}