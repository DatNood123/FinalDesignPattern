using CuoiKy_DP.DataObject;
using CuoiKy_DP.DataObject.Colors;
using CuoiKy_DP.DataObject.Factory;
using CuoiKy_DP.DataObject.TypeCar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy_DP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bF_Click(object sender, EventArgs e)
        {
         
            //Wheel w = new Wheel(1111, "Rubber", "Metal");
            //var c = (Wheel)w.Clone();
            //MessageBox.Show(c.size.ToString());
            //Console.WriteLine(c.size.ToString());
            //Engine engine = new Engine(10, "Md", "10.2");
            //CarColor color = new WhiteColor();
            
            //GasolineCar car = new GasolineCar(w, engine, color, "GB", "Sedan", 1000, 0, "A95");
            //GasolineCar car2 = (GasolineCar) car.Clone();

            
            //MessageBox.Show(car.gearBox.GetHashCode().ToString());
            //car.gearBox = "GBB";
            //MessageBox.Show(car2.gearBox.GetHashCode().ToString());
           
            
            CarFactory carbuilder = new CarFactory();

            var eCar = carbuilder.createCar(WheelType.DTDModel01_26, EngineType.DEngine01, ColorType.Black, GearBoxType.Manual, ModelType.Sedan, 20000, 0, CarType.Diesel);
            if(eCar.GetType().Equals(typeof(DieselCar)))
            {
                MessageBox.Show(eCar.GetType().Name);
                //eCar = (GasolineCar) eCar;
            }

            MessageBox.Show(eCar.wheel.size.ToString());
            MessageBox.Show(eCar.color.colorName.ToString());
            MessageBox.Show(eCar.engine.horsePower.ToString());
            MessageBox.Show(eCar.gearBox.ToString());
            MessageBox.Show(eCar.modelCar.ToString());
        }
    }
}
