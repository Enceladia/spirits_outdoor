Author: Christina Pagger
Designer: Katharina Herzele

--Login--

The Login Service consists of 2 Panels that represent the Login and Register Feature. The Input gets forwarded to the
enceladia server, that analizes the Input and returns if the login/register was successful. Successful Login or Register leads
automaticaly to the start of the main scene.

--Position--

The Position Service starts with the PositionManager. It starts the GPS Service, after it succesfully got a connection,
it calls the getPlaceXML function from the PlaceDownload Script. This Script downloads the xml File from Google Places
and give it to the parsePlacesXML function from the PlaceParser Script witch reads through the xml File and creates a List
of Objects. This list is given to the startPOIinit function from the PositionPOI Script that instantiates different Prefabs
from the Objects in the List. This Instance of the POI recieves a BasePOI Component, that contains all Information about this
Place.

PositionManager -> PlaceDownload -> GooglePlaces -> PlaceParser -> PositionPOI