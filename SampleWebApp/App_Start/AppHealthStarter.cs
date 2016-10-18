using System;
using AppHealth;

[assembly: WebActivator.PreApplicationStartMethod(
    typeof(SampleWebApp.App_Start.MySuperPackage), "PreStart")]

namespace SampleWebApp.App_Start {
    public static class MySuperPackage {
        public static void PreStart() {
            ApplicationHealth.sendApplicationHealth();
        }
    }
}