package com.teddy.hashdemo;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

import java.util.HashMap;
import java.util.Map;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void playingWithHashes() {
        Map<String, Integer> hashTable = new HashMap<>();
        hashTable.put("TwentyThree", 23);
        //hashTable.putIfAbsent("TwentyThree", 666);

        Integer twentyThree = hashTable.get("TwentyThree");
    }
}
