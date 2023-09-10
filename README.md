# Create_Splunk_Apps

# Create Splunk Apps
## This folder contains the code that can be loaded into visual studio project and as a VB.NET application.  Feel free to modify and add any capabilities that you feel are lacking.  

# Splunk app
## If you don't want to compile the code, download the Splunk App folder and its five files contained within.  If you double click the CreateSplunkApps.exe you will have a functioning app to build Splunk apps. 

## App Info
### On this page, you will have the option to the file location for where you will deploy the Splunk apps "Where to Deploy Apps".  The name of the Splunk Folder, in future versions, the apps folders will contain this prefix before the name of the app, so for example splunk_foo_indexer_settings.  The final option is the "Timeout Session for Web UI in Minutes" which is how long Splunk web allows the user to be inactive before they will be logged out and will need to resubmit their credentials.  This time is in minutes

## Licensing
### Check this checkbox if you want a licensing app created.  This will not provide you with a valid license. You still must provide Splunk with a valid license but if a valid license is provided, this app will provide the set up of the license master and clients.  You will need to provide the IP address of your license server.  Do not provide a port, just the IP address.  The app will default to port 8089.  

## Deployment Server
### Check this box if you want to use a deployment server.  Provide the IP address of the deployment server.  Do not provide a port.  The app will default to port 8089.  

## Forwarding
### Check this box if you want to set up forwarding of logs to another server.  It will default to forwarding to port 9997.  You can choose the thruput from the system sending logs.  If bandwith is a concern, you can shrink the amount of KiloBytes per second that can be sent.  If left as a zero, there will be no thresholding.  

## Indexers
### Here you can provide one or many different indexer IP addresses.  Click on the clear list to remove the default IP address and then add as many IP addresses as you need in the "Add IP Address of Indexer" text box, one at a time, add press the Add button until all appear in the list.  

## Index Size Settings
### This window provides a lot of options. The first is to provide the default storage location of the indexes.  This is located in the "Volume:Property" text box.  Unless you need to save it to another location, the default location should work for most Linux installs.  "Max MB" is the text box that represents the largest size partition for your indexes.  Set this size to fill up the majority of your disk space but not enought to run out of enough disk space to keep the Operaing system running.  Somewhere between 90 and 95 percent capacity is a good rule of thumb.  

### The last set of text boxes are the default indexes that ship with Splunk.  The text boxes are the names of the indexes, the warm, cold, and thawed path, and the Max MB size for each index.  You can set the Max MB for each index.  This allows granular control of the size of each index.  Instead of going with the default sizes, you should set the size of these internal indexes.  The current default settings for this app are not best practice.  They definitely are way too small to run a healthy splunk and environment and should be adjusted or don't deploy the indexes.conf files to a production system.  

## Cluster Index
### Click the check box if you want to set up Cluster Indexing.  "The Cluster Label" is the textbox that will contain the name of the Cluster. It needs to be unique if you have more than one indexer cluster.  
### "Replication Factor" is the number of copies of the logs being indexed will be stored.  3 is the default.  
### "Search Factor" determines the number of searchable copies of data the indexer cluster maintains. In other words, the search factor determines the number of searchable copies of each bucket. The default value for the search factor is 2, meaning that the cluster maintains two searchable copies of all data. 
### "Pass 4 Symm Key for Cluster" is the password that will allow an indexer to join the indexer cluster.  
### "Pass 4 Symm Key for Indexer Discovery", is the password a search head needs to be able to dynamically discover all of the available indexes in a cluster. Currently indexers discovery is not set up but will be part of future versions of this application.  
### It is against best practice to use the same symm key for both fields.  
