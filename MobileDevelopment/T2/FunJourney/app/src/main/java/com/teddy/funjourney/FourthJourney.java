package com.teddy.funjourney;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class FourthJourney extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_fourth_journey);

        final Intent endIntent = new Intent(this, EndJourney.class);
        final Intent fifthIntent = new Intent(this, FifthJourney.class);

        final Button kill4Button = findViewById(R.id.kill4Button);
        final Button continueButton = findViewById(R.id.continueButton);

        kill4Button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(endIntent);
            }
        });

        continueButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(fifthIntent);
            }
        });
    }
}
