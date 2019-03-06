package com.teddy.activitysketch;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class SecondActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second);

        final Intent blueIntent = new Intent(this, MainActivity.class);

        final Button button = findViewById(R.id.pushBlueButton);
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Log.i("BLUE", "THE SHINY BLUE BUTTON");
                startActivity(blueIntent);
            }
        });
    }
}
