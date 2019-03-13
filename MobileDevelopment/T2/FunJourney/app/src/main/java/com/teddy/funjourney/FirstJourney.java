package com.teddy.funjourney;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class FirstJourney extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_first_journey);

        TextView mainText = (TextView) findViewById(R.id.firstText);
        mainText.setText("First Journey");
        mainText.setTextSize(18);
    }
}
