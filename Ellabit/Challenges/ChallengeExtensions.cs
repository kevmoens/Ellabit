namespace Ellabit.Challenges
{
    public static class ChallengeExtensions
    {
        public static string DescriptionCleanup(this string text)
        {
            string output = text.ReplaceLineEndings("<br/>");
            var removeLocations = new List<int>();
            GetBreaksToRemove(output, removeLocations);
            output = RemoveBreaks(output, removeLocations);
            return output;
        }

        private static void GetBreaksToRemove(string output, List<int> removeLocations)
        {
            int adjacentCount = 1;
            int pos2 = -1;
            int pos = output.IndexOf("<br/>");
            do
            {
                if (pos2 != -1)
                {
                    pos = pos2;
                }

                pos2 = output.IndexOf("<br/>", pos + 4);
                if (pos2 == -1)
                {
                    break; // No more breaks
                }
                if (pos + 5 == pos2)
                {
                    //Adjacent                    
                    CheckForTooManyBreaks(removeLocations, ref adjacentCount, pos2);
                    continue;
                }

                if (string.IsNullOrWhiteSpace(output.Substring(pos + 5, pos2 - pos - 5)))
                {
                    CheckForTooManyBreaks(removeLocations, ref adjacentCount, pos2);
                    continue;
                }

                adjacentCount = 1;

            } while (pos >= 0);
        }

        private static void CheckForTooManyBreaks(List<int> removeLocations, ref int adjacentCount, int pos)
        {
            adjacentCount++;
            if (adjacentCount > 2)
            {
                //Remove the <br/>
                System.Diagnostics.Debug.Print("Remove the <br/>");
                removeLocations.Add(pos);
            }
        }

        private static string RemoveBreaks(string output, List<int> removeLocations)
        {
            foreach (int posRemove in removeLocations.OrderByDescending(x => x))
            {
                output = output.Substring(0, posRemove) + output.Substring(posRemove + 5);
            }

            return output;
        }
    }
}
