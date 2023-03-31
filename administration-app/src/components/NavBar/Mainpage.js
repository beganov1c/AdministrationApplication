import '../../App.css';
import React, { useEffect, useState } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import { NavBar } from './NavBar';
import { TransactionsList } from '../TransactionsView/transactions/TransactionsList';
import { Home } from './Home';
import { Payment } from '../Payment/Payment';

export const Mainpage = () => {
	const [paymentInfo, setPaymentInfo] = useState(null);
	return (
		<div className='App'>
			<Router>
				<NavBar />
				<Routes>
					<Route path='/' element={<Home />} />
					<Route path='/transactions' element={<TransactionsList setPaymentInfo={setPaymentInfo} />} />
					<Route path='/payment' element={<Payment paymentInfo={paymentInfo} />} />
				</Routes>
			</Router>
		</div>
	);
};
