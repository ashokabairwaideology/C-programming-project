//
//  ViewController.swift
//  Calculator
//
//  Created by Bekzod Rakhmatov on 28/08/2017.
//  Copyright © 2017 Bekzod Rakhmatov. All rights reserved.
//

import UIKit

class ViewController: UIViewController
{

    @IBOutlet weak var outputLabel: UILabel!

    enum Operation: String
    {
        case Divide = "/"
        case Multiply = "*"
        case Subtract = "-"
        case Add = "+"
        case Empty = "Empty"
        case Clear = "Clear"
    }

    var currentOperation = Operation.Empty
    var runningNumber = ""
    var leftValStr = ""
    var rightValStr = ""
    var result = ""
    let clear = ""

    override func viewDidLoad()
    {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
        outputLabel.text = "0"
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }

    @IBAction func numberPressed(sender: UIButton)
    {
        runningNumber += "\(sender.tag)"
        outputLabel.text = runningNumber
    }

    @IBAction func onDividePressed(sender: AnyObject)
    {
        processOperation(operation: .Divide)
    }

    @IBAction func onMultiplyPressed(sender: AnyObject)
    {
        processOperation(operation: .Multiply)
    }

    @IBAction func onAddPressed(sender: AnyObject)
    {
        processOperation(operation: .Add)
    }

    @IBAction func onSubtractPressed(sender: AnyObject)
    {
        processOperation(operation: .Subtract)
    }

    @IBAction func onEqualPressed(sender: AnyObject)
    {
        processOperation(operation: currentOperation)
    }

    @IBAction func onClearPressed(sender: AnyObject)
    {
        processOperation(operation: .Clear)
        currentOperation = Operation.Empty
        outputLabel.text = "0"
    }

    
    func processOperation(operation: Operation)
    {
        if currentOperation != Operation.Empty
        {
            if runningNumber != ""
            {
                rightValStr = runningNumber
                runningNumber = ""

                if currentOperation == Operation.Multiply
                {
                    result = "\(Double(leftValStr)! * Double(rightValStr)!)"
                }
                else if currentOperation == Operation.Divide
                {
                    result = "\(Double(leftValStr)! / Double(rightValStr)!)"
                }
                else if currentOperation == Operation.Add
                {
                    result = "\(Double(leftValStr)! + Double(rightValStr)!)"
                }
                else if currentOperation == Operation.Subtract
                {
                    result = "\(Double(leftValStr)! - Double(rightValStr)!)"
                }
                leftValStr = result
                outputLabel.text = result
            }
            currentOperation = operation
        }
        else
        {
            leftValStr = runningNumber
            runningNumber = ""
            currentOperation = operation
        }
    }
}


