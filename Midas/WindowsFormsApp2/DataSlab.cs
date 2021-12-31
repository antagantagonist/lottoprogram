using System;
using System.Collections.Generic;

public class DataSlab
{
    //everything we'll need:

    //for mode
    int[] mode = new int[36];

    //for mean
    int[] mean = new int[36];
    int mean_avg;
    int mode_avg;
    int sDev_mean;
    int sDev_mode;
    //add values to help calculate stan. dev. in method

    //for range
    int[] range = new int[36];
    List<int> lowestNum = new List<int>();
    List<int> highestNum = new List<int>();

    //for sextiles
    int[] sextiles = new int[6];

    //for margins
    //note: always exclude origin numbers for margins (ex. a margin of 0 to 1 is 0)
    //LAWS:
    //* The addition of all margins = 31
    //* The mean will always be 5.2 which is rounded to 5
    //* The stan. dev is 5
    int[] marg_mode = new int[32];

    String compiledData;
    String tickets;
    Random r = new Random();

    //results compiled from recieved file
    public int[,] ticketData { get; set; }
    public int size { get; set; }

    //object declaration
    public DataSlab(int[,] input, int Size)
    {
        ticketData = input;
        size = Size;

    }

    //==========================PROCESSING THE DATA==========================//

    //make each row be in order numerically
    public void reorganizeData()
    {
        int x;
        int y;
        int[] temp = new int[5];

        for (y = 0; y < size; y++)
        {
            //dump the values into the temp 1 dim array
            for (x = 0; x < 5; x++)
            {
                temp[x] = ticketData[y, x];
            }

            //sort least to greatest
            Array.Sort(temp);
            x = 0;

            //spit back out
            for (x = 0; x < 5; x++)
            {
                ticketData[y, x] = temp[x];
            }
            x = 0;
        }
    }

    // get mode data
    public void modeData()
    {
        int x;
        int y;

        for (y = 0; y < size; y++)
        {
            //dump the values into the temp 1 dim array
            for (x = 0; x < 5; x++)
            {
                mode[ticketData[y, x] - 1] += 1;
            }
            x = 0;
        }

        y = 0;

        //for (y = 0; y < 36; y++)
        //{
        //System.Diagnostics.Debug.WriteLine(mode[y]);
        //}
    }

    public void meanData()
    {
        //vars used
        int x;
        int y;
        int result;
        double output;
        double count = 0;
        int temp = 0;
        double total = 0;
        double row_mean;

        //get the collection of means
        for (y = 0; y < size; y++)
        {
            for (x = 0; x < 5; x++)
            {
                temp += ticketData[y, x];
            }

            row_mean = temp / 5;
            result = Convert.ToInt32(Math.Round(row_mean, 0));
            mean[result] += 1;

            x = 0;
            temp = 0;
        }

        y = 0;
        //find the mean of means
        for (y = 0; y < 36; y++)
        {
            count += mean[y];
            total += (y + 1) * mean[y];
        }
        //save
        output = total / count;
        mean_avg = Convert.ToInt32(Math.Round(output, 0));

        //reset
        count = 0;
        total = 0;
        output = 0;
        y = 0;
        //find the mean of modes
        for (y = 0; y < 36; y++)
        {
            count += mode[y];
            total += (y + 1) * mode[y];
        }
        //save
        output = total / count;
        mode_avg = Convert.ToInt32(Math.Round(output, 0));

        //reset
        double variance = 0;
        count = 0;
        total = 0;
        output = 0;
        y = 0;
        x = 0;
        //find the standard dev of means
        for (y = 0; y < 36; y++)
        {
            count += mean[y];

            for (x = mean[y]; x > 0; x--)
            {
                total += (Math.Pow(((y + 1) - mean_avg), 2));
            }
        }

        variance = total / count;
        sDev_mean = Convert.ToInt32(Math.Round(Math.Sqrt(variance)));

        //reset
        variance = 0;
        count = 0;
        total = 0;
        output = 0;
        y = 0;
        x = 0;
        //find the standard dev of modes
        for (y = 0; y < 36; y++)
        {
            count += mode[y];

            for (x = mode[y]; x > 0; x--)
            {
                total += (Math.Pow(((y + 1) - mode_avg), 2));
            }
        }

        variance = total / count;
        sDev_mode = Convert.ToInt32(Math.Round(Math.Sqrt(variance)));
    }

    //get range data
    public void rangeData()
    {
        int x;
        int y;
        int result;

        //get highest and lowest numbers, and save the range between them
        for (y = 0; y < size; y++)
        {
            lowestNum.Add(ticketData[y, 0]);
            highestNum.Add(ticketData[y, 4]);

            result = ticketData[y, 4] - ticketData[y, 0];
            range[result] += 1;
        }
    }

    public void sextileData()
    {

        int x;
        int y;

        for (y = 0; y < size; y++)
        {
            //dump the values into the temp 1 dim array
            for (x = 0; x < 5; x++)
            {
                if (ticketData[y, x] <= 6)
                {
                    sextiles[0] += 1;
                }
                else if (ticketData[y, x] > 6 && ticketData[y, x] <= 12)
                {
                    sextiles[1] += 1;
                }
                else if (ticketData[y, x] > 12 && ticketData[y, x] <= 18)
                {
                    sextiles[2] += 1;
                }
                else if (ticketData[y, x] > 18 && ticketData[y, x] <= 24)
                {
                    sextiles[3] += 1;
                }
                else if (ticketData[y, x] > 24 && ticketData[y, x] <= 30)
                {
                    sextiles[4] += 1;
                }
                else if (ticketData[y, x] > 30)
                {
                    sextiles[5] += 1;
                }
            }
            x = 0;
        }
    }

    public void marginData()
    {

        int x;
        int y;
        int p = 0;
        int t;


        //get the margins
        for (y = 0; y < size; y++)
        {
            for (x = 0; x < 5; x++)
            {
                //check margin position
                switch (x)
                {
                    //tests the distance (a-1) between 0 and the number in question
                    case 0:
                        t = ticketData[y, x] - 1;
                        marg_mode[t] += 1;
                        p = ticketData[y, x];

                        break;
                    //tests the distance between 37 and the last number in the set
                    case 4:
                        t = (ticketData[y, x] - p) - 1;
                        marg_mode[t] += 1;
                        marg_mode[(37 - ticketData[y, x]) - 1] += 1;

                        break;
                    //tests the difference between 2 numbers
                    default:
                        t = (ticketData[y, x] - p) - 1;
                        marg_mode[t] += 1;
                        p = ticketData[y, x];

                        break;
                }
            }
            x = 0;
        }

    }

    //==========================PRINTING THE DATA==========================//

    public String printData()
    {
        //print all the mode data
        compiledData += "Modes: \r\n";
        for (int i = 0; i < 36; i++)
        {
            compiledData += (i + 1) + " : " + mode[i] + "\r\n";
        }
        compiledData += "\r\n";

        compiledData += "Means \r\n";
        for (int i = 0; i < 36; i++)
        {
            compiledData += i + " : " + mean[i] + "\r\n";
        }

        compiledData += "\r\n";
        compiledData += "The Mean is " + mode_avg + "\r\n";
        compiledData += "The Stan. Dev. is " + sDev_mode + "\r\n";
        compiledData += "The Mean of Means is " + mean_avg + "\r\n";
        compiledData += "The Stan. Dev. is " + sDev_mean + "\r\n";
        compiledData += "\r\n";

        compiledData += "Ranges \r\n";
        for (int i = 0; i < 36; i++)
        {
            compiledData += i + " : " + range[i] + "\r\n";
        }
        compiledData += "\r\n";

        compiledData += "Sextiles \r\n";
        for (int i = 0; i < 6; i++)
        {
            compiledData += (i + 1) + " : " + sextiles[i] + "\r\n";
        }
        compiledData += "\r\n";

        compiledData += "Margins \r\n";
        for (int i = 0; i < 32; i++)
        {
            compiledData += i + " : " + marg_mode[i] + "\r\n";
        }
        compiledData += "\r\n";

        return compiledData;
    }

    //==========================CREATING NEW DATA==========================//

    //--------------------------PACHINKO METHODS---------------------------//

    public int poolCommon(int number)
    {
        int total = 0;
        int roll = 0;

        //add through the numbers
        for (int i = 0; i < 36; i++)
        {
            total += mode[i];
            //if a value is matched or lower than it, select the number
            if (number <= total)
            {
                roll = i + 1;
                break;
            }
        }

        return roll;
    }

    public int poolAverages(int number)
    {

        int roll = 0;
        int flip = 0;

        //magic numbers: 68.2% of a graph spread (distance of 1 stan. dev in either direction)
        if (number >= 158 && number <= 682)
        {
            roll = r.Next((mode_avg - sDev_mode), (mode_avg + sDev_mode));
        }
        //magic numbers: 13.6% of the graph spread on either side (excluded areas of 2 stan. devs)
        else if ((number >= 22 && number < 158) || (number > 682 && number <= 840))
        {
            //randomly choose which direction of the spread to take
            flip = r.Next(2);
            //check if the resulting stand dev. distance is negative
            if (flip == 0)
            {
                if (mode_avg - (sDev_mode * 2) < 0)
                {
                    roll = r.Next(1, (mode_avg - sDev_mode));
                }
                else
                {
                    //futureproof genericism for bigger numbers
                    roll = r.Next((mode_avg - (sDev_mode * 2)), (sDev_mode + 1));
                }
            }
            else
            {
                roll = r.Next((mode_avg + sDev_mode), (mode_avg + (sDev_mode * 2)));
            }
        }
        //magic numbers: 2.2% of the graph spread on either side (excluded distances of 3 stan. devs)
        else if ((number >= 1 && number < 22) || (number > 840 && number <= 999))
        {
            flip = r.Next(2);
            if (flip == 0)
            {
                if (mode_avg - (sDev_mode * 3) < 0)
                {
                    roll = r.Next(1, (mode_avg - sDev_mode));
                }
                else
                {
                    roll = r.Next((mode_avg - (sDev_mode * 3)), (mode_avg - (sDev_mode * 2)) + 1);
                }
            }
            else
            {
                if (mode_avg + (sDev_mode * 3) > 36)
                {
                    roll = r.Next((mode_avg + sDev_mode), (mode_avg + (sDev_mode * 2)));
                }
                else
                {
                    roll = r.Next((mode_avg + (sDev_mode * 2)), (mode_avg + (sDev_mode * 3)));
                }
            }
        }

        return roll;
    }

    public int poolSextiles(int number)
    {

        int total = 0;
        int roll = 0;
        int counter = 1;

        //add through the numbers
        for (int i = 0; i < 6; i++)
        {
            total += sextiles[i];
            //if a value is matched or lower than it, select the number
            if (number <= total)
            {
                roll = r.Next(counter, counter + 6);
                break;
            }
            //increment counter (note, the counter must always go up by 6, as the second part of the rand metric reduces it (i.e. 7+6 is 13, but the latter part counts to 12)
            counter = counter + 6;
        }
        return roll;
    }

    public int[] poolRanges(int number)
    {
        int[] roll = new int[5];
        int Rrange = 0;
        int total = 0;
        int lowest = 0;
        int highest = 0;

        //add through the numbers
        for (int i = 0; i < 36; i++)
        {
            total += range[i];
            //if a value is matched or lower than it, select the number
            if (number <= total)
            {
                Rrange = i;

                highest = r.Next(Rrange + 1, 37);
                roll[4] = highest;

                lowest = highest - Rrange;
                roll[0] = lowest;

                break;
            }
        }

        for (int i = 1; i < 4; i++)
        {
            roll[i] = r.Next(lowest + 1, highest);
        }

        return roll;
    }

    public int[] poolMargins()
    {

        int sum = 0;
        int total = 0;
        int check = 0;
        int number = 0;
        int[] roll = new int[5];
        int[] margins = new int[6];

        for (int x = 0; x < 32; x++)
        {
            sum += marg_mode[x];
        }

        //iterate through the array of margins
        for (int i = 0; i < 6; i++)
        {

            //seed number
            number = r.Next(1, sum + 1);
            total = 0;

            //choose number from seed
            for (int j = 0; j < 32; j++)
            {
                total += mode[j];
                //if a value is matched or lower than it, select the number
                if (number <= total)
                {
                    margins[i] = j;
                    break;
                }
            }

            check = 0;

            //checking for malformed margin creation
            for (int k = 0; k <= i; k++)
            {

                check += margins[k];

                //if its prematurely 31, kill the last number and do it over
                //the same goes if at the last value, it is all in total greater than 31
                if ((check >= 31 && k < 5) || (check > 31 && k == 5))
                {
                    margins[k] = 0;
                    i = i - 1;
                    break;
                }
                //if the set is created and its less than 31, dump the whole thing and start over
                if (check < 31 && k == 5)
                {
                    i = 0;
                    break;
                }
            }
        }

        //assuming the margins were assembled correctly in the right parameters
        //we build the ticket
        for (int l = 0; l < 5; l++)
        {
            switch (l)
            {
                case 0:
                    roll[l] = 0 + (margins[l] + 1);
                    break;
                default:
                    roll[l] = roll[l - 1] + (margins[l] + 1);
                    break;
            }
        }
        return roll;
    }

    //--------------------------GENERATOR METHODS--------------------------//

    public String genMachine(int amount)
    {
        //establish variables
        int[] ticket = new int[5];
        int number;
        int temp;
        int check = 0;
        tickets = "";

        for (int i = 0; i < amount; i++)
        {
            check = i;
            //make a ticket
            for (int j = 0; j < 5; j++)
            {
                number = r.Next(1, 37);
                ticket[j] = number;
            }

            //sort the ticket
            Array.Sort(ticket);
            temp = 0;

            //confirm there are no repeat numbers in the ticket
            for (int k = 0; k < 5; k++)
            {
                if (temp == ticket[k])
                {
                    check = i - 1;
                    break;
                }
                temp = ticket[k];
            }

            //secure confirmation: print ticket to string if successful, redo if not
            if (check < i)
            {
                //i is reduced in the loop in the case of failure, forcing a redo
                i = i - 1;
            }
            else
            {
                //if successful, print each element into the string
                for (int l = 0; l < 5; l++)
                {
                    tickets += ticket[l] + " ";
                }

                tickets += "\r\n";
            }
        }

        return tickets;
    }

    public String genPools(int amount)
    {
        tickets = "";
        int total = 0;
        int[] ticket = new int[5];
        int number;
        int roll;
        int temp;
        int check = 0;

        //add everything up
        for (int i = 0; i < 36; i++)
        {
            total += mode[i];
        }

        for (int i = 0; i < amount; i++)
        {

            check = i;
            //make a ticket
            for (int j = 0; j < 5; j++)
            {
                number = r.Next(1, (total + 1));
                roll = poolCommon(number);
                ticket[j] = roll;
            }

            //sort the ticket
            Array.Sort(ticket);
            temp = 0;

            //confirm there are no repeat numbers in the ticket
            for (int k = 0; k < 5; k++)
            {
                if (temp == ticket[k])
                {
                    check = i - 1;
                    break;
                }
                temp = ticket[k];
            }

            //secure confirmation: print ticket to string if successful, redo if not
            if (check < i)
            {
                //i is reduced in the loop in the case of failure, forcing a redo
                i = i - 1;
            }
            else
            {
                //if successful, print each element into the string
                for (int l = 0; l < 5; l++)
                {
                    tickets += ticket[l] + " ";
                }

                tickets += "\r\n";
            }
        }

        return tickets;
    }

    public String genAverages(int amount)
    {
        tickets = "";
        int[] ticket = new int[5];
        int number;
        int roll;
        int temp;
        int check = 0;

        for (int i = 0; i < amount; i++)
        {

            check = i;
            //make a ticket
            for (int j = 0; j < 5; j++)
            {
                number = r.Next(1, 1000);
                roll = poolAverages(number);
                ticket[j] = roll;
            }

            //sort the ticket
            Array.Sort(ticket);
            temp = 0;

            //confirm there are no repeat numbers in the ticket
            for (int k = 0; k < 5; k++)
            {
                if (temp == ticket[k])
                {
                    check = i - 1;
                    break;
                }
                temp = ticket[k];
            }

            //secure confirmation: print ticket to string if successful, redo if not
            if (check < i)
            {
                //i is reduced in the loop in the case of failure, forcing a redo
                i = i - 1;
            }
            else
            {
                //if successful, print each element into the string
                for (int l = 0; l < 5; l++)
                {
                    tickets += ticket[l] + " ";
                }

                tickets += "\r\n";
            }
        }

        return tickets;
    }

    public String genStrat(int amount)
    {
        tickets = "";

        tickets = "";
        int total = 0;
        int[] ticket = new int[5];
        int number;
        int roll;
        int temp;
        int check = 0;

        //add everything up
        for (int i = 0; i < 6; i++)
        {
            total += sextiles[i];
        }

        for (int i = 0; i < amount; i++)
        {

            check = i;
            //make a ticket
            for (int j = 0; j < 5; j++)
            {
                number = r.Next(1, (total + 1));
                roll = poolSextiles(number);
                ticket[j] = roll;
            }

            //sort the ticket
            Array.Sort(ticket);
            temp = 0;

            //confirm there are no repeat numbers in the ticket
            for (int k = 0; k < 5; k++)
            {
                if (temp == ticket[k])
                {
                    check = i - 1;
                    break;
                }
                temp = ticket[k];
            }

            //secure confirmation: print ticket to string if successful, redo if not
            if (check < i)
            {
                //i is reduced in the loop in the case of failure, forcing a redo
                i = i - 1;
            }
            else
            {
                //if successful, print each element into the string
                for (int l = 0; l < 5; l++)
                {
                    tickets += ticket[l] + " ";
                }

                tickets += "\r\n";
            }
        }

        return tickets;
    }

    public String genRange(int amount)
    {

        tickets = "";
        int total = 0;
        int[] ticket = new int[5];
        int number;
        int temp;
        int check = 0;

        for (int i = 0; i < 36; i++)
        {
            total += range[i];
        }

        for (int i = 0; i < amount; i++)
        {
            check = i;

            number = r.Next(1, (total + 1));
            ticket = poolRanges(number);

            //sort the ticket
            Array.Sort(ticket);
            temp = 0;

            //confirm there are no repeat numbers in the ticket
            for (int k = 0; k < 5; k++)
            {
                if (temp == ticket[k])
                {
                    check = i - 1;
                    break;
                }
                temp = ticket[k];
            }

            //secure confirmation: print ticket to string if successful, redo if not
            if (check < i)
            {
                //i is reduced in the loop in the case of failure, forcing a redo
                i = i - 1;
            }
            else
            {
                //if successful, print each element into the string
                for (int l = 0; l < 5; l++)
                {
                    tickets += ticket[l] + " ";
                }

                tickets += "\r\n";
            }
        }

        return tickets;
    }

    public String genMargins(int amount)
    {

        tickets = "";
        int[] ticket = new int[5];
        int[] result = new int[5];
        int temp;
        int check = 0;

        for (int i = 0; i < amount; i++)
        {

            ticket = poolMargins();

            //sort the ticket
            Array.Sort(ticket);
            temp = 0;

            for (int l = 0; l < 5; l++)
            {
                tickets += ticket[l] + " ";
            }

            tickets += "\r\n";

            
        }
        return tickets;

    }
}

