# Chess Game:
Coded by Aliziwe Qeqe

# Start-up
1. I started by  copy and pasting all the images of the chess pieces that I would need from google.
2. I then used an AI backgrond remover to remove the background of each image so that only the piece would be visible and seen on the chess board.
3. I created a folder labled 'Images' inside my project that held all the image pieces.
4. I divided my grid into 64 even squares ( 8 x 8) by using:
       <Grid.ColumnDefinitions>
          <ColumnDefinition></ColumnDefinition>
       </Grid.ColumnDefinitions>
       <Grid.RowDefinitions>
          <RowDefinition></RowDefinition>
       </Grid.RowDefinitions>
5. I then dragged all the images and resized them to fir into each grid square.
6. I renamed each chess piece uniquley.
7. I finally made the checkerboard design by using the border tag and specifing the Grid.Row and Grid.Column and setting the background to either 'black' or 'white'
