package com.teddy.demo;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Mammal mammal = new Mammal();
        Bird bird = new Bird();

        Log.i("MainActivity", "Hello PG's");
        Log.i("MainActivity", mammal.type() + mammal.propulsionType() + mammal.birthType());
        Log.i("MainActivity", bird.type() + bird.propulsionType() + bird.birthType());

        TextView myTextView = (TextView) findViewById(R.id.textView);
        myTextView.setText("YoYoYo");
    }
}
