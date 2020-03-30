using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMechine
{
    class CoffeMechine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;

        public CoffeMechine(CoffePowder powder, WaterGalon galon) {
            this.waterGalon = galon;
            this.coffePowder = powder;
        }

        public String makeEsspresso() {
            if (!this.waterGalon.isAvailable()) {
                return "Sorry, the water is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your coffe is ready";

        }

        public String checkAvailability() {
            return $"the water :{this.waterGalon.getVolume()} and the coffe powder : {this.coffePowder.getNetto()}";
        }
    }

}
