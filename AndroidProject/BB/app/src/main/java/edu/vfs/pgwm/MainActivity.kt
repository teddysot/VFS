package edu.vfs.pgwm

import android.content.Intent
import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        this.doItButton.setOnClickListener { View ->
            Toast.makeText(View.context, "Popped it up", Toast.LENGTH_SHORT).show()
        }

        this.activityButton.setOnClickListener { View ->
            startActivity(
                Intent(View.context, SecondActivity::class.java).putExtra("message", "Was here")
            )
        }
    }

    override fun onResume() {
        super.onResume()
        Toast.makeText(this.applicationContext, "Resume", Toast.LENGTH_SHORT).show()
    }
}
