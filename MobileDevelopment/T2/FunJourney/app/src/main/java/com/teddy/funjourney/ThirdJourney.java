package com.teddy.funjourney;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class ThirdJourney extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_third_journey);

        final Intent endIntent = new Intent(this, EndJourney.class);
        final Intent fourthIntent = new Intent(this, FourthJourney.class);

        final Button kill3Button = findViewById(R.id.kill3Button);
        final Button waitButton = findViewById(R.id.waitButton);

        kill3Button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(endIntent);
            }
        });

        waitButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(fourthIntent);
            }
        });
    }
}
