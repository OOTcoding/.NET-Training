<Query Kind="Statements" />

StringBuilder[] builders = new StringBuilder [5];
builders [0] = new StringBuilder ("builder1");
builders [1] = new StringBuilder ("builder2");
builders [2] = new StringBuilder ("builder3");

StringBuilder[] builders2 = builders;
StringBuilder[] shallowClone = (StringBuilder[]) builders.Clone();
shallowClone [2] = shallowClone[2].Append("33333");
builders[2].Dump();
builders2[2].Dump();
shallowClone[2].Dump();
(builders[0] == builders2[0]).Dump ("Comparing first element of each array");
(builders[0] == shallowClone[0]).Dump ("Comparing first element of each array");