echo "Welcome to my restaurant, our speciality is Jamaican food"

echo "Here is our menu, make your choices:"
echo "Enter 1 for Jerk chicken/fish"
echo "Enter 2 for Oxtail & rice"
echo "Enter 3 for Fish Escovitch"
read resp

# Using IF statements
if [ "$resp" == "1" ]
then 
echo "You will love it"
echo " Enter 1 for chicken and 2 for fish?"
read resp1
fi

if [ "$resp1" == "1" ]
then 
echo "Ok, You want Jerk chicken."
echo "Someone is taking care of your order!"
fi

if [ "$resp1" == "2" ]
then 
echo "Ok! You want Jerk fish."
echo "Someone is taking care of your order!"
fi


if [ "$resp" == "2" ]
then 
echo "How you want your plantains?"
echo "Enter 1 for sweety and 2 for salty"
read resp2
fi

if [ "$resp2" == "1" ]
then 
echo "Like me. I love sweet banana." 
echo "Ok, You want oxtail & rice with sweet banana"
echo "Someone is taking care of your order!"
fi

if [ "$resp2" == "2" ]
then 
echo "ok, you prefer salty"
echo "Someone is taking care of your order!"
fi


if [ "$resp" == "3" ]
then 
echo "Ok. You want Fish Escovitch."
echo "Someone is taking care of your order!"
fi
