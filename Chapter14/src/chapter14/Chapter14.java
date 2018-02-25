/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package chapter14;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.Label;
import javafx.scene.layout.GridPane;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.stage.Stage;

/**
 *
 * @author shark
 */
public class Chapter14 extends Application {

    @Override // Override the start method in the Application class 
    public void start(Stage primaryStage) {
        // Create a pane to hold the image views 
        GridPane pane = new GridPane();

        //Place nodes in the pane
        pane.add(new ImageView(new Image("www.cs.armstrong.edu/liang/image/us.gif")), 0, 0);
        pane.add(new ImageView(new Image("www.cs.armstrong.edu/liang/image/us.gif")), 1, 0);
        pane.add(new ImageView(new Image("www.cs.armstrong.edu/liang/image/us.gif")), 0, 1);
        pane.add(new ImageView(new Image("www.cs.armstrong.edu/liang/image/us.gif")), 1, 1);
        
        // Create a scene and place it in the stage 
        Scene scene = new Scene(pane);
        primaryStage.setTitle("ShowImage"); // Set the stage title 
        primaryStage.setScene(scene); // Place the scene in the stage 
        primaryStage.show(); // Display the stage
    }

    public static void main(String[] args) {
        // TODO code application logic here
        Application.launch(args);
    }
}
