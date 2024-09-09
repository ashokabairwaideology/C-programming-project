//
//  ViewController.swift
//  Calculator for iOS 11
//
//  Created by Bekzod Rakhmatov on 30/08/2017.
//  Copyright © 2017 Bekzod Rakhmatov. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var outputLabel: UILabel!

    enum Operation: String {
        case Divide = "/"
        case Multiply = "*"
        case Subtract = "-"
        case Percentage = "%"
        case Add = "+"
        case Empty = "Empty"
        case Clear = "Clear"
    }

    var currentOperation = Operation.Empty
    var runningNumber = ""
    var leftValueStr = ""
    var rightValueStr = ""
    var result = ""


    override func viewDidLoad() {
        super.viewDidLoad()
        outputLabel.text = "0"
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }

    @IBAction func onNumberPressed(sender: UIButton) {
        runningNumber += "\(sender.tag)"
        outputLabel.text = runningNumber
    }

    @IBAction func onDividePressed(sender: AnyObject) {
        processOperation(operation: .Divide)
    }
    @IBAction func onMultiplyPressed(sender: AnyObject) {
        processOperation(operation: .Multiply)
    }
    @IBAction func onAddPressed(sender: AnyObject) {
        processOperation(operation: .Add)
    }
    @IBAction func onSubtractPressed(sender: AnyObject) {
        processOperation(operation: .Subtract)
    }
    @IBAction func onEqualPressed(sender: AnyObject) {
        processOperation(operation: currentOperation)
    }
    @IBAction func onPercentagePressed(sender: AnyObject) {
        processOperation(operation: .Percentage)
    }
    @IBAction func onClearPressed(sender: AnyObject) {
        processOperation(operation: .Clear)
        currentOperation = Operation.Empty
        outputLabel.text = "0"
    }
    func processOperation(operation: Operation) {
        if currentOperation != Operation.Empty {
            if runningNumber != "" {
                rightValueStr = runningNumber
                runningNumber = ""

                if currentOperation == Operation.Multiply {
                    result = "\(Double(leftValueStr)! * Double(rightValueStr)!)"
                }
                else if currentOperation == Operation.Divide {
                    result = "\(Double(leftValueStr)! / Double(rightValueStr)!)"
                }
                else if currentOperation == Operation.Subtract {
                    result = "\(Double(leftValueStr)! - Double(rightValueStr)!)"
                }
                else if currentOperation == Operation.Add {
                    result = "\(Double(leftValueStr)! + Double(rightValueStr)!)"
                }
                else if currentOperation == Operation.Percentage {
                    result = "\(Double(leftValueStr)! / 100.0)"
                    result = "\(Double(rightValueStr)! / 100.0)"
                }
                leftValueStr = result
                outputLabel.text = result
            }
            currentOperation = operation
        }
        else {
            leftValueStr = runningNumber
            runningNumber = ""
            currentOperation = operation
        }
    }


}

