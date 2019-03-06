package com.teddy.activitysketch;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        final Intent redIntent = new Intent(this, SecondActivity.class);

        final Button button = findViewById(R.id.pushRedButton);
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Log.i("RED", "THE SHINY RED BUTTON");
                startActivity(redIntent);
            }
        });
    }
}
