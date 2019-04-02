package com.teddy.listview;

import android.content.Intent;
import android.provider.MediaStore;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;

import org.w3c.dom.Text;

import java.util.List;

public class MainActivity extends AppCompatActivity{

    Class[] Activities = {PikachuActivity.class, GroudonActivity.class};

        int[] IMAGES = {R.drawable.pikachu, R.drawable.groudon};

        String[] NAMES = {"Pikachu", "Groudon"};

        String[] DESC = {"Yellow Pokemon", "Red Legendary"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ListView listView = (ListView) findViewById(R.id.theList);

        CustomAdapter customAdapter = new CustomAdapter();

        listView.setAdapter(customAdapter);
    }

    class CustomAdapter extends BaseAdapter{

        @Override
        public int getCount() {
            return IMAGES.length;
        }

        @Override
        public Object getItem(int position) {
            return null;
        }

        @Override
        public long getItemId(int position) {
            return 0;
        }

        @Override
        public View getView(int position, View convertView, ViewGroup parent) {
            convertView = getLayoutInflater().inflate(R.layout.customlayout, null);

            ImageView imageView = (ImageView) convertView.findViewById(R.id.imageView);
            TextView textView_name = (TextView) convertView.findViewById(R.id.textView_name);
            TextView textView_desc = (TextView) convertView.findViewById(R.id.textView_description);

            imageView.setImageResource(IMAGES[position]);
            textView_name.setText(NAMES[position]);
            textView_desc.setText(DESC[position]);

            final Class activityPosition = Activities[position];

            convertView.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    startActivity(new Intent(MainActivity.this, activityPosition));
                }
            });

            return convertView;
        }
    }
}
