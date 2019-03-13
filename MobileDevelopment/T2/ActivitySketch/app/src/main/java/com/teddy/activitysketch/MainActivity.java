package com.teddy.activitysketch;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.PopupMenu;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements PopupMenu.OnMenuItemClickListener {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        final Intent redIntent = new Intent(this, SecondActivity.class);

        final Button button = findViewById(R.id.pushRedButton);
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(redIntent);
            }
        });

        final Button popupButton = findViewById(R.id.popupButton);
        popupButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                showPopup(v);
            }
        });

        // Get button by ID

        // Set ut's listener to our self
    }

    @Override
    public boolean onMenuItemClick(MenuItem item){

        Toast t = Toast.makeText(this, item.getTitle(), Toast.LENGTH_LONG);
        t.show();
        return false;
    }

    public void showPopup(View v){
        PopupMenu popupMenu = new PopupMenu(this, v);
        popupMenu.setOnMenuItemClickListener(this);
        popupMenu.inflate(R.menu.popup_menu);
        popupMenu.show();
    }
}
