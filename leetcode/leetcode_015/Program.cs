using System;

namespace leetcode_015
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] point1 = new int[] { -5, -1 };
            int[] point2 = new int[] { -3, 0 };
            int[] point3 = new int[] { -1, -1 };
            int[] point4 = new int[] { 1, 2 };
            int[] point5 = new int[] { 5, -3 };
            int[] point6 = new int[] { 2, 4 };
            //int[] point7 = new int[] { 6, 0 };
            //int[] point8 = new int[] { 9, 1 };
            //int[] point9 = new int[] { 10, 1};
            Console.WriteLine(new Solution().MaxPoints(new int[][] { point1, point2, point3 , point4 , point5 , point6}));
        }
    }

    public class Solution
    {
        public int MaxPoints(int[][] points)
        {          
            int[][] sortedPoints = points;
            int maximumSegment = 0;                                     
            int x = 0;
            int y = 1;
            

            //SortPointsX(sortedPoints, 0, points.Length - 1);
            //SortPointsY(sortedPoints);

            // search by X
            //maximumSegment = FindingSegmentParallelToTheCoordinateAxis(sortedPoints, maximumSegment, y);             

            // search by Y
            //maximumSegment = FindingSegmentParallelToTheCoordinateAxis(sortedPoints, maximumSegment, x);

            // search by XY
            maximumSegment = FindingDiagonalSegment(sortedPoints, maximumSegment);
                     

            return maximumSegment;
        }
        
        private int FindingSegmentParallelToTheCoordinateAxis(int[][] sortedPoints, int maximumSegment, int plane)
        {
            int firstPoint = 0;
            int nextPoint;           
            int intermediateResult;
            
            while (firstPoint < sortedPoints.Length)
            {
                intermediateResult = 1;
                nextPoint = firstPoint + 1;

                while (nextPoint < sortedPoints.Length)
                {
                    if (sortedPoints[firstPoint][plane] == sortedPoints[nextPoint][plane])
                    {                        
                        intermediateResult++;
                    }
                    nextPoint++;
                }

                if (intermediateResult > maximumSegment)
                {
                    maximumSegment = intermediateResult;
                } 

                firstPoint++;               
            }

           

            return maximumSegment;
        }


        
        private int FindingDiagonalSegment(int[][] sortedPoints, int maximumSegment)
        {
            int firstPoint = 0;
            int nexPoints;
            int intermediateResult = 1;
            int x = 0;
            int y = 1;
            int sX;
            int sY;
            int shiftX;
            int shiftY;


            while (firstPoint + 1 < sortedPoints.Length)
            {
                intermediateResult = 1;
                nexPoints = firstPoint + 1;
                sX = Math.Abs(sortedPoints[nexPoints][x] - sortedPoints[firstPoint][x]);
                sY = Math.Abs(sortedPoints[nexPoints][y] - sortedPoints[firstPoint][y]);                

                while (nexPoints < sortedPoints.Length)
                {
                    shiftX = sX;
                    shiftY = sY;

                    while (shiftX <= Math.Abs(sortedPoints[firstPoint][x]) + Math.Abs(sortedPoints[nexPoints][x]))
                    {
                        Console.WriteLine(sortedPoints[firstPoint][x] + shiftX + "x = x" + sortedPoints[nexPoints][x] + ":" + (sortedPoints[firstPoint][y] + shiftY) + "y=y" + sortedPoints[nexPoints][y]);
                        Console.WriteLine((sortedPoints[firstPoint][x] - shiftX) + " x = x" + sortedPoints[nexPoints][x] + ":" + (sortedPoints[firstPoint][y] - shiftY) + "y=y" + sortedPoints[nexPoints][y]);
                        if (sortedPoints[firstPoint][x] + shiftX == sortedPoints[nexPoints][x] && sortedPoints[firstPoint][y] + shiftY == sortedPoints[nexPoints][y])
                        {
                            intermediateResult++;
                            break;
                        }
                        else if (sortedPoints[firstPoint][x] - shiftX == sortedPoints[nexPoints][x] && sortedPoints[firstPoint][y] - shiftY == sortedPoints[nexPoints][y])
                        {
                            intermediateResult++;
                            break;
                        }
                        

                        shiftX += sX;
                        shiftY += sY;
                    }                   


                    nexPoints++;

                }

                if (intermediateResult > maximumSegment)
                {
                    maximumSegment = intermediateResult;
                }

                firstPoint++;

            }            

            return maximumSegment;
        }
        private void SortPointsX(int[][] points, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = PartitionX(points, left, right);
                SortPointsX(points, left, pivotIndex - 1);
                SortPointsX(points, pivotIndex + 1, right);
            }
        }

        private int PartitionX(int[][] points, int left, int right)
        {
            int pivot = points[right][0];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (points[j][0] <= pivot)
                {
                    i++;
                    SwapX(points, i, j);
                }
            }

            SwapX(points, i + 1, right);
            return i + 1;
        }

        private void SortPointsY(int[][] points)
        {
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < points.Length; i++)
            {
                startIndex = i;

                while (i+1 < points.Length)
                {
                    if (points[i][0] == points[i + 1][0])
                    {
                        endIndex = i + 1;
                        i++;
                    }
                    else
                        break;
                }
                SortY(points, startIndex, endIndex);               

            }
        }
        private void SortY(int[][] points, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = PartitionY(points, left, right);
                SortY(points, left, pivotIndex - 1);
                SortY(points, pivotIndex + 1, right);
            }
        }
        private int PartitionY(int[][] points, int left, int right)
        {            
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (points[j][1] <= points[right][1] && points[j][0] == points[right][0])
                {
                    i++;
                    SwapY(points, i, j);
                }
            }

            SwapY(points, i + 1, right);
            return i + 1;
        }
        private void SwapX(int[][] points, int i, int j)
        {               
            (points[i],points[j]) = (points[j],points[i]);            
        }

        private void SwapY(int[][] points, int i, int j)
        {
            Console.WriteLine(points[i][0] + "<>" + points[j][0]);
            if (points[i][0] == points[j][0])
                (points[i], points[j]) = (points[j], points[i]);
        }


    }
}
