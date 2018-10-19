using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        #region member variables
        //desk quote description
        private string CustomerName { get; set; }
        private DateTime QuoteDate { get; set; }
        public int RushDays { get; set; }
        private Desk Desk = new Desk();
        public int QuoteAmount { get; set; }

        #endregion

        private int SurfaceArea = 0;
        private int DrawerCost = 0;
        private int MaterialCost;
        private int RushCost = 0;

        #region constants
        private const int PRICE_BASE = 200;
        private const int BASE_SURFACE_AREA_PRICE = 1; //extra cost per square inch greater than desktop size threshold
        private const int PRICE_PER_DRAWER = 50;
        private const int SIZE_THRESHOLD = 1000; //inches squared
        private const int RUSH1 = 3; // rush order days options
        private const int RUSH2 = 5;
        private const int RUSH3 = 7;
        private const int RUSH_THRESHOLD = 2000; //inches squared

        #endregion
                        
        public DeskQuote(string customerName, DateTime quoteDate, int width, int depth, int numberDrawers, DesktopMaterial surfaceMaterial, int rushDays)
        {

            CustomerName = customerName;
            QuoteDate = quoteDate;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumberDrawers = numberDrawers;
            Desk.DesktopMaterial = surfaceMaterial;
            RushDays = rushDays;

            //calculate surface area
            SurfaceArea = Desk.Width * Desk.Depth;

            //calculate cost of the drawers
            DrawerCost = numberDrawers * PRICE_PER_DRAWER;

            if(RushDays == RUSH1)
            {
                if(SurfaceArea < 1000)
                {
                    RushCost = 60;
                }
                else if (SurfaceArea >= 1000 && SurfaceArea <= 2000)
                {
                    RushCost = 70;
                }
                else if (SurfaceArea > 2000)
                {
                    RushCost = 80;
                }
            }
            else if(RushDays == RUSH2)
            {
                if (SurfaceArea < 1000)
                {
                    RushCost = 40;
                }
                else if (SurfaceArea >= 1000 && SurfaceArea <= 2000)
                {
                    RushCost = 50;
                }
                else if (SurfaceArea > 2000)
                {
                    RushCost = 60;
                }

            }
            else if(RushDays == RUSH3)
            {
                if (SurfaceArea < 1000)
                {
                    RushCost = 30;
                }
                else if (SurfaceArea >= 1000 && SurfaceArea <= 2000)
                {
                    RushCost = 35;
                }
                else if (SurfaceArea > 2000)
                {
                    RushCost = 40;
                }
            }
            else{
                RushCost = 0;
            }

        }

        public int CalculateQuoteTotal()
        {
            QuoteAmount = PRICE_BASE + SurfaceAreaCost() + DrawerCost + (int)Desk.DesktopMaterial + RushCost;
            return QuoteAmount;
        }

        public int SurfaceAreaCost()
        {
            if(SurfaceArea > SIZE_THRESHOLD)
            {
                return (SurfaceArea - SIZE_THRESHOLD) * BASE_SURFACE_AREA_PRICE;
            }
            else
            {
                return 0;
            }
        }
    }
}
