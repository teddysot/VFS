package com.teddy.demo;

public class Bird extends Animal implements IPropulsion {
    @Override
    public String type() {
        return "Bird";
    }

    @Override
    public String birthType() {
        return "Lays Egg";
    }

    @Override
    public String propulsionType() {
        return "Wings";
    }
}
