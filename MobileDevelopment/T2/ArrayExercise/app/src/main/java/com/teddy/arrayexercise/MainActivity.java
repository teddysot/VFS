package com.teddy.arrayexercise;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;

public class MainActivity extends AppCompatActivity {

    public int getSum(int[] theArray){
        int result = 0;
        for(int i : theArray){
            result += i;
        }

        return result;
    }

    public int getAverage(int[] theArray){

        int result = getSum(theArray) / theArray.length;

        return result;
    }

    public int getMax(int[] theArray){
        int biggest = Integer.MIN_VALUE;
        for(int z : theArray) {
            if(z > biggest){
                biggest = z;
            }
        }

        return biggest;
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        String TAG = "Array Stuff";

        int [] constantArrayValues = { 24, 666, -42, 42, 1010101, 7, 6, 16, 99, 21};

        int sum = getSum(constantArrayValues);
        Log.v(TAG, "the sum is " + sum);

        int average = getAverage(constantArrayValues);
        Log.v(TAG, "the average is " + average);

        int max = getMax(constantArrayValues);
        Log.v(TAG, "the max is " + max);
    }
}
