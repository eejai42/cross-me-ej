/*************************************************
Initially Generated by SSoT.me - 2017
    EJ Alexandra - ssotme odxml42/odxml-to-csharp-pocos
    This file WILL NOT be overwritten once changes are made.
*************************************************/
using System;
using System.ComponentModel;
                        
namespace crossmegame.Lib.DataClasses
{                   
    
    public partial class Command 
    {
        public Command()
        {
            this.InitPoco();
        }

        public override String ToString()
        {
            return String.Format("Command: {0}", this.Name);
        }
                            
    }
}