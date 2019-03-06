package com.teddy.demo;

public class Mammal extends Animal implements IPropulsion {

    @Override
    public String type() {
        return "Mammal";
    }

    @Override
    public String birthType() {
        return "Live Birth";
    }

    @Override
    public String propulsionType() {
        return "Legs";
    }
}
