# WebcamImageClassification
A WinForms example of ML.NET image classification through webcam.
You can experience preparing training data, generating models, and classifying images in real time with a webcam.

![Image](appimage.png)

# Requirements
* Windows 10
* .NET Core3.1
* A webcam(usbcam)

# Usege
## Step1. Gathering data
1. Select a folder to save data-set.
1. Enter a label for the image to be captured in the "Label name" field.
1. Taking images as training data with a webcam.
1. Repeat 2 and 3 for the number of labels you want to classify.

## Step2. Generate model
1. Just push [Genarate] button in "2.Generate model" tab.
pipeline.zip and model.zip will be created in the data-set folder.

After the training is finished, the result will be displayed as an HTML file as shown below.
![Image](resultimage.png)

## Step3. Consume model
1. Push [InitCam] button in "3.Consume model" tab.
1. Push [Start classify] button. You will see which label it was classified under and its score in real time. 


