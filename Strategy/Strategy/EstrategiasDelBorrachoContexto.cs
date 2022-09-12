using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class EstrategiasDelBorrachoContexto
    {
        private IBorracho oBorracho;

        public enum Comportamiento 
        {
            HacerOjitos, InvitaCerveza, HacerCaradeGalan
        }

        public EstrategiasDelBorrachoContexto() 
        {
            this.oBorracho = new EstrategiaOjitos();
        }

        //public void EstablecerConquistaOjitos()
        //{ 
        //    this.oBorracho = new EstrategiaOjitos();
        //}

        //public void EsatablecerConquistaInvitarCervea() 
        //{
        //    this.oBorracho = new EstrategiaInvitarCerveza();
        //}

        public void Conquistar(Comportamiento opcion) 
        {
            switch (opcion) 
            {
                case (Comportamiento.HacerOjitos):
                {
                    this.oBorracho = new EstrategiaOjitos();
                }break;
                case (Comportamiento.InvitaCerveza):
                {
                     this.oBorracho = new EstrategiaInvitarCerveza();
                }break;
                case (Comportamiento.HacerCaradeGalan):
                {
                     this.oBorracho = new EstrategiaHacerCaradeGalan();
                }break;
            }
            this.oBorracho.Conquistar();
        }
    }
}
