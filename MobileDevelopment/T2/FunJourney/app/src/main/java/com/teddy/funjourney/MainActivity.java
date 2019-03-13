package com.teddy.funjourney;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        TextView mainText = (TextView) findViewById(R.id.homeText);
        mainText.setText("Welcome to Fun Journey");
        mainText.setTextSize(18);

        final Intent firstIntent = new Intent(this, FirstJourney.class);

        final Button button = findViewById(R.id.startButton);
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(firstIntent);
            }
        });
    }
}
