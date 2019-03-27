package com.teddy.listview;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.List;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        final String items[] = { "Drill", "Tooth Soraper", "Frigtening Needle",
                "Gravy Flavoured Flouride", "Bag of Teeth"};
        final ArrayAdapter<String> itemListAdaptor = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, items);

        ListView L = (ListView) findViewById(R.id.theList);
        L.setAdapter(itemListAdaptor);

        L.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Log.v("TAG", items[position]);
            }
        });
    }
}
