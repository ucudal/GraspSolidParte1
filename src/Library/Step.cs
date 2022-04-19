//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        //Para asignar esta responsabilidad se utiliza el patron Expert, ya que Step es el experto que conoce toda
        // la información sobre los precios y cantidades de cada paso
        public double GetProductionCost()
        {
            double equipment = this.Equipment.HourlyCost * this.Time;
            double insumos = this.Input.UnitCost * this.Quantity;
            return equipment+insumos;
        }
    }
}