using CuoiKy_DP.DataObject.Colors;
using CuoiKy_DP.DataObject.Produce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy_DP.DataObject.Factory
{
    internal class CarFactory
    {
        public Car createCar(WheelType wheelType, EngineType engineType, ColorType colorType, string gearBox, string modelCar, float maxFuelCapacity, float fuelCapacity, CarType carType, string recommentGas = null)
        {
            Wheel wheel = (Wheel) ElectricCarBuilder.electricCar.wheel.Clone();
            switch(wheelType)
            {
                case WheelType.DWheelModel1:
                    wheel.size = 100;
                    wheel.tireMaterial = "Rubber";
                    wheel.boneMaterial = "Aluminum";

                    break;
                case WheelType.DWheelModel2:
                    wheel.size = 110;
                    wheel.tireMaterial = "Rubber";
                    wheel.boneMaterial = "Aluminum";

                    break;
                case WheelType.DWheelModel3:
                    wheel.size = 115;
                    wheel.tireMaterial = "Rubber";
                    wheel.boneMaterial = "Aluminum";

                    break;
            }

            Engine engine = (Engine) ElectricCarBuilder.electricCar.engine.Clone();
            switch(engineType)
            {
                case EngineType.DEngineModel1:
                    engine.horsePower = 1000;
                    engine.nameEngine = "DF8";
                    engine.version = "1.1";
                    break;
                case EngineType.DEngineModel2:
                    engine.horsePower = 1100;
                    engine.nameEngine = "DF8+";
                    engine.version = "1.2";
                    break;
                case EngineType.DEngineModel3:
                    engine.horsePower = 1200;
                    engine.nameEngine = "DF8++";
                    engine.version = "1.3";
                    break;
            }

            CarColor color = new WhiteColor();
            switch (colorType)
            {
                case ColorType.White:
                    color = new WhiteColor();
                    break;
                case ColorType.Blue:
                    color = new BlueColor();
                    break;
                case ColorType.Black:
                    color = new BlackColor();
                    break;
                case ColorType.Green:
                    color = new GreenColor();
                    break;
                case ColorType.Red:
                    color = new RedColor();
                    break;
            }

            switch (carType)
            {
                case CarType.Diesel:
                    DieselCarBuilder dCarBuilder = new DieselCarBuilder();
                    dCarBuilder.setWheel(wheel);
                    dCarBuilder.setEngine(engine);
                    dCarBuilder.setColor(color);
                    dCarBuilder.setGear(gearBox);
                    dCarBuilder.setModel(modelCar);
                    dCarBuilder.setMaxTankVolume(maxFuelCapacity);
                    dCarBuilder.setFuelTankeVolume(fuelCapacity);
                    dCarBuilder.setRecommentGas(recommentGas);

                    return dCarBuilder.BuildCar();
                    //break;
                case CarType.Electric:
                    ElectricCarBuilder eCarBuilder = new ElectricCarBuilder();
                    eCarBuilder.setWheel(wheel);
                    eCarBuilder.setEngine(engine);
                    eCarBuilder.setColor(color);
                    eCarBuilder.setGear(gearBox);
                    eCarBuilder.setModel(modelCar);
                    eCarBuilder.setMaxBetteryCapacity(maxFuelCapacity);
                    eCarBuilder.setBetteryCapacity(fuelCapacity);

                    return eCarBuilder.BuildCar();
                    //break;
                case CarType.Gasoline:
                    GasolineCarBuilder gCarBuilder = new GasolineCarBuilder();
                    gCarBuilder.setWheel(wheel);
                    gCarBuilder.setEngine(engine);
                    gCarBuilder.setColor(color);
                    gCarBuilder.setGear(gearBox);
                    gCarBuilder.setModel(modelCar);
                    gCarBuilder.setMaxTankVolume(maxFuelCapacity);
                    gCarBuilder.setFuelTankeVolume(fuelCapacity);
                    gCarBuilder.setRecommentGas(recommentGas);

                    return gCarBuilder.BuildCar();
                    //break;
            }
            return null;
        }
    }
}
