package com.teddy.funjourney;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class FirstJourney extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_first_journey);

        final Intent endIntent = new Intent(this, EndJourney.class);
        final Intent secondIntent = new Intent(this, SecondJourney.class);

        final Button escapeButton = findViewById(R.id.escapeButton);
        final Button keepButton = findViewById(R.id.keepButton);

        escapeButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(endIntent);
            }
        });

        keepButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(secondIntent);
            }
        });
    }
}
