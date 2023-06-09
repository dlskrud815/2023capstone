﻿using GMap.NET.WindowsForms;
using System;
using System.Drawing;

namespace EUV.Controls
{
    /// <summary>
    /// Mono handles calls from other thread difrently - this prevents those crashs
    /// </summary>
    public class myGMAP : GMap.NET.WindowsForms.GMapControl
    {
        public bool inOnPaint = false;
        string otherthread = "";
        int lastx = 0;
        int lasty = 0;
        public myGMAP()
            : base()
        {
            this.Text = "Map";
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            var start = DateTime.Now;

            if (inOnPaint)
            {
                Console.WriteLine("Was in onpaint Gmap th:" + System.Threading.Thread.CurrentThread.Name + " in " + otherthread);
                return;
            }

            otherthread = System.Threading.Thread.CurrentThread.Name;

            inOnPaint = true;

            try
            {
                base.OnPaint(e);
            }
            catch { }

            inOnPaint = false;

            var end = DateTime.Now;

            ///System.Diagnostics.Debug.WriteLine("map draw time " + (end - start).TotalMilliseconds);
        }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                // try prevent alot of cpu usage
                if (e.X >= lastx - 2 && e.X <= lastx + 2 && e.Y >= lasty - 2 && e.Y <= lasty + 2)
                    return;

                lastx = e.X;
                lasty = e.Y;

                base.OnMouseMove(e);
            }
            catch { }
        }

        internal GMapMarker GetMarkerFromPoint(Point local)
        {
            throw new NotImplementedException();
        }
    }
}
