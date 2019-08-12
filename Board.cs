﻿using System;

namespace chess
{
	public class Board
	{
		private ChessPiece[] chessPieces = new ChessPiece[32];
		private ChessPiece[,] chessBoard = new ChessPiece[8,8];
		public Board(int colorSel){//player selected color as input
			int horizontal = 0;//for setting up the board keeping track of which horizonal line it is on
			int pieceNum = 0;//for tracking which piece in pieces is being setup on the board
			if(colorSel==0){//sets all pieces to default locations and colors for white selection
				while(horizontal<8){
					for(int i=0; i<8; i++){
						if(i==0){
							if(horizontal==0||horizontal==7){//rooks
								chessPieces[pieceNum] = new Rook(pieceNum, 1);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==1||horizontal==6){//knights
								chessPieces[pieceNum] = new Knight(pieceNum, 1);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==2||horizontal==5){//bishops
								chessPieces[pieceNum] = new Bishop(pieceNum, 1);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==3){//queen
								chessPieces[pieceNum] = new Queen(pieceNum, 1);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==4){//king
								chessPieces[pieceNum] = new King(pieceNum, 1);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
						}
						else if(i==1){//pawns
							chessPieces[pieceNum] = new Pawn(pieceNum, 1);
							chessPieces[pieceNum].setLocation(horizontal, i);
							chessBoard[horizontal, i] = chessPieces[pieceNum];
							pieceNum++;
						}
						else if(i==6){//pawns
							chessPieces[pieceNum] = new Pawn(pieceNum, 0);
							chessPieces[pieceNum].setLocation(horizontal, i);
							chessBoard[horizontal, i] = chessPieces[pieceNum];
							pieceNum++;
						}
						else if(i==7){//rooks
							if(horizontal==0||horizontal==7){
								chessPieces[pieceNum] = new Rook(pieceNum, 0);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==1||horizontal==6){//knights
								chessPieces[pieceNum] = new Knight(pieceNum, 0);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==2||horizontal==5){//bishops
								chessPieces[pieceNum] = new Bishop(pieceNum, 0);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==3){//queen
								chessPieces[pieceNum] = new Queen(pieceNum, 0);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==4){//king
								chessPieces[pieceNum] = new King(pieceNum, 0);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
						}
					}
					horizontal++;
				}
			}
			else{//sets all pieces to default locations and colors for black selection
				while(horizontal<8){
					for(int i=0; i<8; i++){
						if(i==0){
							if(horizontal==0||horizontal==7){//rooks
								chessPieces[pieceNum] = new Rook(pieceNum, 0);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==1||horizontal==6){//knights
								chessPieces[pieceNum] = new Knight(pieceNum, 0);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==2||horizontal==5){//bishops
								chessPieces[pieceNum] = new Bishop(pieceNum, 0);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==3){//queen
								chessPieces[pieceNum] = new Queen(pieceNum, 0);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==4){//king
								chessPieces[pieceNum] = new King(pieceNum, 0);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
						}
						else if(i==1){//pawns
							chessPieces[pieceNum] = new Pawn(pieceNum, 0);
							chessPieces[pieceNum].setLocation(horizontal, i);
							chessBoard[horizontal, i] = chessPieces[pieceNum];
							pieceNum++;
						}
						else if(i==6){//pawns
							chessPieces[pieceNum] = new Pawn(pieceNum, 1);
							chessPieces[pieceNum].setLocation(horizontal, i);
							chessBoard[horizontal, i] = chessPieces[pieceNum];
							pieceNum++;
						}
						else if(i==7){//rooks
							if(horizontal==0||horizontal==7){
								chessPieces[pieceNum] = new Rook(pieceNum, 1);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==1||horizontal==6){//knights
								chessPieces[pieceNum] = new Knight(pieceNum, 1);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==2||horizontal==5){//bishops
								chessPieces[pieceNum] = new Bishop(pieceNum, 1);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==3){//queen
								chessPieces[pieceNum] = new Queen(pieceNum, 1);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
							else if(horizontal==4){//king
								chessPieces[pieceNum] = new King(pieceNum, 1);
								chessPieces[pieceNum].setLocation(horizontal, i);
								chessBoard[horizontal, i] = chessPieces[pieceNum];
								pieceNum++;
							}
						}
					}
					horizontal++;
				}
			}
			
		}
		
		public ChessPiece[] getPieces(){
			return chessPieces;
		}
		
		public ChessPiece[,] getBoard(){
			return chessBoard;
		}
	}
}
