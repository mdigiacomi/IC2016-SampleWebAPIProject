using System;
using AppHealth;

[assembly: WebActivator.PreApplicationStartMethod(
    typeof(IC2016_SampleProject.App_Start.MySuperPackage), "PreStart")]

namespace IC2016_SampleProject.App_Start {
    public static class MySuperPackage {
        public static void PreStart() {
            ApplicationHealth.sendApplicationHealth();
        }
    }
}