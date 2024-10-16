*** Settings ***
Library    calculator.py

*** Variables ***
${NUM1}    3
${NUM2}    4

*** Test Cases ***
Test Sum Of Two Numbers
    ${a}=    Convert To Integer    ${NUM1}
    ${b}=    Convert To Integer    ${NUM2}
    ${expected}=    Convert To Integer    7

    ${result}=    Sum    ${a}    ${b}
    Should Be Equal    ${result}    ${expected}

Test Product Of Two Numbers
    ${a}=    Convert To Integer    ${NUM1}
    ${b}=    Convert To Integer    ${NUM2}
    ${expected}=    Convert To Integer    12

    ${result}=    Product    ${a}    ${b}
    Should Be Equal    ${result}    ${expected}
