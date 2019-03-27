package com.teddy.funjourney;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class FifthJourney extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_fifth_journey);

        final Intent endIntent = new Intent(this, EndJourney.class);

        final Button kill5Button = findViewById(R.id.kill5Button);
        final Button tellButton = findViewById(R.id.tellButton);

        kill5Button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(endIntent);
            }
        });

        tellButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(endIntent);
            }
        });
    }
}
