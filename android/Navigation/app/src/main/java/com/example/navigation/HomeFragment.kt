package com.example.navigation

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import androidx.navigation.fragment.findNavController

class HomeFragment : Fragment() {

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        // Inflate the layout for this fragment
        val view =  inflater.inflate(R.layout.fragment_home, container, false)
        val btnIrTela2 = view.findViewById<Button>(R.id.btnIrTela2)

        btnIrTela2.setOnClickListener{
            findNavController().navigate(R.id.action_homeFragment_to_tela2Fragment)
        }

        return view
    }
}