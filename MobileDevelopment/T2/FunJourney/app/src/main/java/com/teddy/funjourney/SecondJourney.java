package com.teddy.funjourney;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class SecondJourney extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second_journey);

        final Intent endIntent = new Intent(this, EndJourney.class);
        final Intent thirdIntent = new Intent(this, ThirdJourney.class);

        final Button kill2Button = findViewById(R.id.kill2Button);
        final Button followButton = findViewById(R.id.followButton);

        kill2Button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(endIntent);
            }
        });

        followButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(thirdIntent);
            }
        });
    }
}
