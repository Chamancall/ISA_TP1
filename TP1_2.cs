using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal static class Prog2
    {
        static void Ex1()
        {
            for (int a = 1; a <= 15; a++)
            {
            if (Check_Prime(a))
                {
                    Console.WriteLine(a + " is Prime");
                }
            }
        }
        private static bool Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)  
            {  
                if ((number % i) == 0)  
                {  
                    return false;  
                }  
            }  
            if (i == number)  
            {  
                return true;  
            }  
            return false;  
        }

        static void Ex2()
        {
            int fiba = 0;
            int fibb = 1;
            for (int i = 1; i <= 15; i++)
            {
                int fib = fiba + fibb;
                fiba = fibb;
                fibb = fib;
                
                Console.WriteLine(fib);
            }
        }

        static void Ex3()
        {
            int a = 6;
            int fac = 1;
            for (int i = 1; i <= a; i++)
            {
                fac = fac * i;
            }
            Console.WriteLine(fac);
        }

        static void Ex4()
        {
            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    Console.WriteLine(10/PowerFunction(i));
                }
                catch
                {
                    Console.WriteLine("oui");
                }
            }
        }
        
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) -4);
        }

        static void Ex5()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            a = a - 1;
            b = b - 1;
            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j <= b; j++)
                {
                    if (i == 0 & j == 0 || i == 0 & j == b || i == a & j == 0 || i == a & j == b)
                    {
                        Console.Write("0");
                    }
                    else if (i == 0 || i == a)
                    {
                        Console.Write("-");
                    } else if (j == 0 || j == b)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Config
    {
        public string data { get; set; }
        public int data_points { get; set; }
        public string interval { get; set; }
        public string symbol { get; set; }
    }

    public class Usage
    {
        public int day { get; set; }
        public int month { get; set; }
    }

    public class TimeSery
    {
        public int asset_id { get; set; }
        public int time { get; set; }
        public double open { get; set; }
        public double close { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double volume { get; set; }
        public object market_cap { get; set; }
        public int url_shares { get; set; }
        public int unique_url_shares { get; set; }
        public int reddit_posts { get; set; }
        public int reddit_posts_score { get; set; }
        public int reddit_comments { get; set; }
        public int reddit_comments_score { get; set; }
        public int tweets { get; set; }
        public int tweet_spam { get; set; }
        public int tweet_followers { get; set; }
        public int tweet_quotes { get; set; }
        public int tweet_retweets { get; set; }
        public int tweet_replies { get; set; }
        public int tweet_favorites { get; set; }
        public int tweet_sentiment1 { get; set; }
        public int tweet_sentiment2 { get; set; }
        public int tweet_sentiment3 { get; set; }
        public int tweet_sentiment4 { get; set; }
        public int tweet_sentiment5 { get; set; }
        public int tweet_sentiment_impact1 { get; set; }
        public int tweet_sentiment_impact2 { get; set; }
        public int tweet_sentiment_impact3 { get; set; }
        public int tweet_sentiment_impact4 { get; set; }
        public int tweet_sentiment_impact5 { get; set; }
        public int social_score { get; set; }
        public double average_sentiment { get; set; }
        public int sentiment_absolute { get; set; }
        public int sentiment_relative { get; set; }
        public int news { get; set; }
        public double price_score { get; set; }
        public double social_impact_score { get; set; }
        public double correlation_rank { get; set; }
        public double galaxy_score { get; set; }
        public double volatility { get; set; }
        public int alt_rank { get; set; }
        public int alt_rank_30d { get; set; }
        public double alt_rank_hour_average { get; set; }
        public int market_cap_rank { get; set; }
        public int percent_change_24h_rank { get; set; }
        public int volume_24h_rank { get; set; }
        public int social_volume_24h_rank { get; set; }
        public int social_score_24h_rank { get; set; }
        public int social_contributors { get; set; }
        public int social_volume { get; set; }
        public double price_btc { get; set; }
        public int social_volume_global { get; set; }
        public double social_dominance { get; set; }
        public object market_cap_global { get; set; }
        public double market_dominance { get; set; }
        public double percent_change_24h { get; set; }
    }

    public class Datum
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public double price { get; set; }
        public double price_btc { get; set; }
        public long market_cap { get; set; }
        public double percent_change_24h { get; set; }
        public double percent_change_7d { get; set; }
        public double percent_change_30d { get; set; }
        public double volume_24h { get; set; }
        public int social_contributors_calc_24h_previous { get; set; }
        public int url_shares_calc_24h_previous { get; set; }
        public int tweet_spam_calc_24h_previous { get; set; }
        public int news_calc_24h_previous { get; set; }
        public double average_sentiment_calc_24h_previous { get; set; }
        public int social_score_calc_24h_previous { get; set; }
        public int social_volume_calc_24h_previous { get; set; }
        public int alt_rank_30d_calc_24h_previous { get; set; }
        public int alt_rank_calc_24h_previous { get; set; }
        public int social_contributors_calc_24h { get; set; }
        public double social_contributors_calc_24h_percent { get; set; }
        public int url_shares_calc_24h { get; set; }
        public double url_shares_calc_24h_percent { get; set; }
        public int tweet_spam_calc_24h { get; set; }
        public double tweet_spam_calc_24h_percent { get; set; }
        public int news_calc_24h { get; set; }
        public double news_calc_24h_percent { get; set; }
        public double average_sentiment_calc_24h { get; set; }
        public double average_sentiment_calc_24h_percent { get; set; }
        public int social_score_calc_24h { get; set; }
        public double social_score_calc_24h_percent { get; set; }
        public int social_volume_calc_24h { get; set; }
        public double social_volume_calc_24h_percent { get; set; }
        public int asset_id { get; set; }
        public int time { get; set; }
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double volume { get; set; }
        public int url_shares { get; set; }
        public int unique_url_shares { get; set; }
        public int reddit_posts { get; set; }
        public int reddit_posts_score { get; set; }
        public int reddit_comments { get; set; }
        public int reddit_comments_score { get; set; }
        public int tweets { get; set; }
        public int tweet_spam { get; set; }
        public int tweet_followers { get; set; }
        public int tweet_quotes { get; set; }
        public int tweet_retweets { get; set; }
        public int tweet_replies { get; set; }
        public int tweet_favorites { get; set; }
        public int tweet_sentiment1 { get; set; }
        public int tweet_sentiment2 { get; set; }
        public int tweet_sentiment3 { get; set; }
        public int tweet_sentiment4 { get; set; }
        public int tweet_sentiment5 { get; set; }
        public int tweet_sentiment_impact1 { get; set; }
        public int tweet_sentiment_impact2 { get; set; }
        public int tweet_sentiment_impact3 { get; set; }
        public int tweet_sentiment_impact4 { get; set; }
        public int tweet_sentiment_impact5 { get; set; }
        public int social_score { get; set; }
        public double average_sentiment { get; set; }
        public int sentiment_absolute { get; set; }
        public int sentiment_relative { get; set; }
        public int news { get; set; }
        public double price_score { get; set; }
        public double social_impact_score { get; set; }
        public double correlation_rank { get; set; }
        public double galaxy_score { get; set; }
        public double volatility { get; set; }
        public int alt_rank { get; set; }
        public int alt_rank_30d { get; set; }
        public double alt_rank_hour_average { get; set; }
        public int market_cap_rank { get; set; }
        public int percent_change_24h_rank { get; set; }
        public int volume_24h_rank { get; set; }
        public int social_volume_24h_rank { get; set; }
        public int social_score_24h_rank { get; set; }
        public int social_contributors { get; set; }
        public int social_volume { get; set; }
        public int social_volume_global { get; set; }
        public double social_dominance { get; set; }
        public long market_cap_global { get; set; }
        public double market_dominance { get; set; }
        public string tags { get; set; }
        public double close { get; set; }
        public List<TimeSery> timeSeries { get; set; }
    }

    public class Root
    {
        public Config config { get; set; }
        public Usage usage { get; set; }
        public List<Datum> data { get; set; }
    }


        
        public static void Main(string[] args)
        {
            Console.WriteLine(Usage.month);
        }
    }
}